using System;
using System.Collections.Generic;
using System.Text;

namespace Common.DataStructures
{
    public class EmailEnvelop
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }

    public  class EmailConfig
    {
        public string Smtp { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
    }

}
