using System;
using System.Collections.Generic;
using System.Text;

namespace HomeOwnerBestie.RealEstateData.Zillow
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd", IsNullable = false)]
    public partial class searchresults
    {

        private request requestField;

        private message messageField;

        private response responseField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public request request
        {
            get
            {
                return this.requestField;
            }
            set
            {
                this.requestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public message message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
        public response response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class request
    {

        private string addressField;

        private string citystatezipField;

        /// <remarks/>
        public string address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public string citystatezip
        {
            get
            {
                return this.citystatezipField;
            }
            set
            {
                this.citystatezipField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class message
    {

        private string textField;

        private string codeField;

        /// <remarks/>
        public string text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class response
    {

        private responseResult[] resultsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("result", IsNullable = false)]
        public responseResult[] results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResult
    {

        private string zpidField;

        private responseResultLinks linksField;

        private responseResultAddress addressField;

        private responseResultZestimate zestimateField;

        private responseResultRentzestimate rentzestimateField;

        private responseResultLocalRealEstate localRealEstateField;

        /// <remarks/>
        public string zpid
        {
            get
            {
                return this.zpidField;
            }
            set
            {
                this.zpidField = value;
            }
        }

        /// <remarks/>
        public responseResultLinks links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
            }
        }

        /// <remarks/>
        public responseResultAddress address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public responseResultZestimate zestimate
        {
            get
            {
                return this.zestimateField;
            }
            set
            {
                this.zestimateField = value;
            }
        }

        /// <remarks/>
        public responseResultRentzestimate rentzestimate
        {
            get
            {
                return this.rentzestimateField;
            }
            set
            {
                this.rentzestimateField = value;
            }
        }

        /// <remarks/>
        public responseResultLocalRealEstate localRealEstate
        {
            get
            {
                return this.localRealEstateField;
            }
            set
            {
                this.localRealEstateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultLinks
    {

        private string homedetailsField;

        private string graphsanddataField;

        private string mapthishomeField;

        private string comparablesField;

        /// <remarks/>
        public string homedetails
        {
            get
            {
                return this.homedetailsField;
            }
            set
            {
                this.homedetailsField = value;
            }
        }

        /// <remarks/>
        public string graphsanddata
        {
            get
            {
                return this.graphsanddataField;
            }
            set
            {
                this.graphsanddataField = value;
            }
        }

        /// <remarks/>
        public string mapthishome
        {
            get
            {
                return this.mapthishomeField;
            }
            set
            {
                this.mapthishomeField = value;
            }
        }

        /// <remarks/>
        public string comparables
        {
            get
            {
                return this.comparablesField;
            }
            set
            {
                this.comparablesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultAddress
    {

        private string streetField;

        private string zipcodeField;

        private string cityField;

        private string stateField;

        private decimal latitudeField;

        private decimal longitudeField;

        /// <remarks/>
        public string street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public string zipcode
        {
            get
            {
                return this.zipcodeField;
            }
            set
            {
                this.zipcodeField = value;
            }
        }

        /// <remarks/>
        public string city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string state
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public decimal latitude
        {
            get
            {
                return this.latitudeField;
            }
            set
            {
                this.latitudeField = value;
            }
        }

        /// <remarks/>
        public decimal longitude
        {
            get
            {
                return this.longitudeField;
            }
            set
            {
                this.longitudeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimate
    {

        private responseResultZestimateAmount amountField;

        private string lastupdatedField;

        private responseResultZestimateOneWeekChange oneWeekChangeField;

        private responseResultZestimateValueChange valueChangeField;

        private responseResultZestimateValuationRange valuationRangeField;

        private string percentileField;

        /// <remarks/>
        public responseResultZestimateAmount amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("last-updated")]
        public string lastupdated
        {
            get
            {
                return this.lastupdatedField;
            }
            set
            {
                this.lastupdatedField = value;
            }
        }

        /// <remarks/>
        public responseResultZestimateOneWeekChange oneWeekChange
        {
            get
            {
                return this.oneWeekChangeField;
            }
            set
            {
                this.oneWeekChangeField = value;
            }
        }

        /// <remarks/>
        public responseResultZestimateValueChange valueChange
        {
            get
            {
                return this.valueChangeField;
            }
            set
            {
                this.valueChangeField = value;
            }
        }

        /// <remarks/>
        public responseResultZestimateValuationRange valuationRange
        {
            get
            {
                return this.valuationRangeField;
            }
            set
            {
                this.valuationRangeField = value;
            }
        }

        /// <remarks/>
        public string percentile
        {
            get
            {
                return this.percentileField;
            }
            set
            {
                this.percentileField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimateAmount
    {

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimateOneWeekChange
    {

        private bool deprecatedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated
        {
            get
            {
                return this.deprecatedField;
            }
            set
            {
                this.deprecatedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimateValueChange
    {

        private string durationField;

        private bool durationFieldSpecified;

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool durationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }
            set
            {
                this.durationFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimateValuationRange
    {

        private responseResultZestimateValuationRangeLow lowField;

        private responseResultZestimateValuationRangeHigh highField;

        /// <remarks/>
        public responseResultZestimateValuationRangeLow low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }

        /// <remarks/>
        public responseResultZestimateValuationRangeHigh high
        {
            get
            {
                return this.highField;
            }
            set
            {
                this.highField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimateValuationRangeLow
    {

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultZestimateValuationRangeHigh
    {

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimate
    {

        private responseResultRentzestimateAmount amountField;

        private string lastupdatedField;

        private responseResultRentzestimateOneWeekChange oneWeekChangeField;

        private responseResultRentzestimateValueChange valueChangeField;

        private responseResultRentzestimateValuationRange valuationRangeField;

        /// <remarks/>
        public responseResultRentzestimateAmount amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("last-updated")]
        public string lastupdated
        {
            get
            {
                return this.lastupdatedField;
            }
            set
            {
                this.lastupdatedField = value;
            }
        }

        /// <remarks/>
        public responseResultRentzestimateOneWeekChange oneWeekChange
        {
            get
            {
                return this.oneWeekChangeField;
            }
            set
            {
                this.oneWeekChangeField = value;
            }
        }

        /// <remarks/>
        public responseResultRentzestimateValueChange valueChange
        {
            get
            {
                return this.valueChangeField;
            }
            set
            {
                this.valueChangeField = value;
            }
        }

        /// <remarks/>
        public responseResultRentzestimateValuationRange valuationRange
        {
            get
            {
                return this.valuationRangeField;
            }
            set
            {
                this.valuationRangeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimateAmount
    {

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimateOneWeekChange
    {

        private bool deprecatedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool deprecated
        {
            get
            {
                return this.deprecatedField;
            }
            set
            {
                this.deprecatedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimateValueChange
    {

        private string durationField;

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimateValuationRange
    {

        private responseResultRentzestimateValuationRangeLow lowField;

        private responseResultRentzestimateValuationRangeHigh highField;

        /// <remarks/>
        public responseResultRentzestimateValuationRangeLow low
        {
            get
            {
                return this.lowField;
            }
            set
            {
                this.lowField = value;
            }
        }

        /// <remarks/>
        public responseResultRentzestimateValuationRangeHigh high
        {
            get
            {
                return this.highField;
            }
            set
            {
                this.highField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimateValuationRangeLow
    {

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultRentzestimateValuationRangeHigh
    {

        private string currencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultLocalRealEstate
    {

        private responseResultLocalRealEstateRegion regionField;

        /// <remarks/>
        public responseResultLocalRealEstateRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultLocalRealEstateRegion
    {

        private string zindexValueField;

        private responseResultLocalRealEstateRegionLinks linksField;

        private string nameField;

        private string idField;

        private string typeField;

        /// <remarks/>
        public string zindexValue
        {
            get
            {
                return this.zindexValueField;
            }
            set
            {
                this.zindexValueField = value;
            }
        }

        /// <remarks/>
        public responseResultLocalRealEstateRegionLinks links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseResultLocalRealEstateRegionLinks
    {

        private string overviewField;

        private string forSaleByOwnerField;

        private string forSaleField;

        /// <remarks/>
        public string overview
        {
            get
            {
                return this.overviewField;
            }
            set
            {
                this.overviewField = value;
            }
        }

        /// <remarks/>
        public string forSaleByOwner
        {
            get
            {
                return this.forSaleByOwnerField;
            }
            set
            {
                this.forSaleByOwnerField = value;
            }
        }

        /// <remarks/>
        public string forSale
        {
            get
            {
                return this.forSaleField;
            }
            set
            {
                this.forSaleField = value;
            }
        }
    }


}
