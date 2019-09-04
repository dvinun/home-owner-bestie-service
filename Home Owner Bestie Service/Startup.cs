using System.Runtime.Loader;
using HomeOwnerBestie.LeadData.DataManager;
using HomeOwnerBestie.LeadData.DataProvider;
using HomeOwnerBestie.LeadData.SQL.Models;
using HomeOwnerBestie.RealEstateData.DataManager;
using HomeOwnerBestie.RealEstateData.DataProvider;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;

namespace HomeOwnerBestie.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var CurrentPath = System.AppDomain.CurrentDomain.BaseDirectory;
            var realEstateAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(CurrentPath + Configuration["RealEstateData:Assembly"]);
            var leadDataAssembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(CurrentPath + Configuration["LeadData:Assembly"]);

            services
                .AddTransient(typeof(IRealEstateDataProvider), realEstateAssembly.GetType(Configuration["RealEstateData:DataProvider:Implementation"]))
                .AddTransient(typeof(IRealEstateDataManager), realEstateAssembly.GetType(Configuration["RealEstateData:DataManager:Implementation"]))
                .AddTransient(typeof(ILeadDataManager), leadDataAssembly.GetType(Configuration["LeadData:DataManager:Implementation"]))
                .AddTransient(typeof(ILeadDataProvider), leadDataAssembly.GetType(Configuration["LeadData:DataProvider:Implementation"]));

            // To overcome cross domain ... issues
            services.AddCors(options => options.AddPolicy("ApiCorsPolicy", builder =>
            {
                builder
                    .AllowAnyOrigin()
                    .WithHeaders(HeaderNames.AccessControlAllowHeaders, "Content-Type")
                    .AllowAnyMethod()
                    .AllowCredentials();
            }));

            services.AddDbContext<HomeOwnerBestieDBContext>(options => options.UseSqlServer(Configuration["LeadData:DataProvider:DataConnection"]));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env,
            IRealEstateDataProvider realEstateDataProvider, IRealEstateDataManager realEstateDataManager,
            ILeadDataManager leadDataManager, ILeadDataProvider leadDataProvider, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            
            app.UseCors("ApiCorsPolicy");
            app.UseCors(builder =>
            builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            app.UseHttpsRedirection();
            app.UseMvc();

        }
    }
}
