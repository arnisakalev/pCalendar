﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pCalendar.WinForm.Admin.pCalendarService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="country", Namespace="http://schemas.datacontract.org/2004/07/ProductionCalendarModel")]
    [System.SerializableAttribute()]
    public partial class country : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short CountryId {
            get {
                return this.CountryIdField;
            }
            set {
                if ((this.CountryIdField.Equals(value) != true)) {
                    this.CountryIdField = value;
                    this.RaisePropertyChanged("CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryName {
            get {
                return this.CountryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryNameField, value) != true)) {
                    this.CountryNameField = value;
                    this.RaisePropertyChanged("CountryName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="calendar", Namespace="http://schemas.datacontract.org/2004/07/ProductionCalendarModel")]
    [System.SerializableAttribute()]
    public partial class calendar : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short CalendarIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CalendarNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short CountryIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short CalendarId {
            get {
                return this.CalendarIdField;
            }
            set {
                if ((this.CalendarIdField.Equals(value) != true)) {
                    this.CalendarIdField = value;
                    this.RaisePropertyChanged("CalendarId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CalendarName {
            get {
                return this.CalendarNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CalendarNameField, value) != true)) {
                    this.CalendarNameField = value;
                    this.RaisePropertyChanged("CalendarName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short CountryId {
            get {
                return this.CountryIdField;
            }
            set {
                if ((this.CountryIdField.Equals(value) != true)) {
                    this.CountryIdField = value;
                    this.RaisePropertyChanged("CountryId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="dtype", Namespace="http://schemas.datacontract.org/2004/07/ProductionCalendarModel")]
    [System.SerializableAttribute()]
    public partial class dtype : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short DTypeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DTypeNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short DTypeId {
            get {
                return this.DTypeIdField;
            }
            set {
                if ((this.DTypeIdField.Equals(value) != true)) {
                    this.DTypeIdField = value;
                    this.RaisePropertyChanged("DTypeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DTypeName {
            get {
                return this.DTypeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DTypeNameField, value) != true)) {
                    this.DTypeNameField = value;
                    this.RaisePropertyChanged("DTypeName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="holiday", Namespace="http://schemas.datacontract.org/2004/07/ProductionCalendarModel")]
    [System.SerializableAttribute()]
    public partial class holiday : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short HolidayIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HolidayNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short HolidayId {
            get {
                return this.HolidayIdField;
            }
            set {
                if ((this.HolidayIdField.Equals(value) != true)) {
                    this.HolidayIdField = value;
                    this.RaisePropertyChanged("HolidayId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string HolidayName {
            get {
                return this.HolidayNameField;
            }
            set {
                if ((object.ReferenceEquals(this.HolidayNameField, value) != true)) {
                    this.HolidayNameField = value;
                    this.RaisePropertyChanged("HolidayName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="region", Namespace="http://schemas.datacontract.org/2004/07/ProductionCalendarModel")]
    [System.SerializableAttribute()]
    public partial class region : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short CountryIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private short RegionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RegionNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short CountryId {
            get {
                return this.CountryIdField;
            }
            set {
                if ((this.CountryIdField.Equals(value) != true)) {
                    this.CountryIdField = value;
                    this.RaisePropertyChanged("CountryId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public short RegionId {
            get {
                return this.RegionIdField;
            }
            set {
                if ((this.RegionIdField.Equals(value) != true)) {
                    this.RegionIdField = value;
                    this.RaisePropertyChanged("RegionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RegionName {
            get {
                return this.RegionNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RegionNameField, value) != true)) {
                    this.RegionNameField = value;
                    this.RaisePropertyChanged("RegionName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="pCalendarService.ICalendarService")]
    public interface ICalendarService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetCountriesList", ReplyAction="http://tempuri.org/ICalendarService/GetCountriesListResponse")]
        pCalendar.WinForm.Admin.pCalendarService.country[] GetCountriesList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetCountriesList", ReplyAction="http://tempuri.org/ICalendarService/GetCountriesListResponse")]
        System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.country[]> GetCountriesListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddCountry", ReplyAction="http://tempuri.org/ICalendarService/AddCountryResponse")]
        int AddCountry(pCalendar.WinForm.Admin.pCalendarService.country Country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddCountry", ReplyAction="http://tempuri.org/ICalendarService/AddCountryResponse")]
        System.Threading.Tasks.Task<int> AddCountryAsync(pCalendar.WinForm.Admin.pCalendarService.country Country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditCountry", ReplyAction="http://tempuri.org/ICalendarService/EditCountryResponse")]
        bool EditCountry(pCalendar.WinForm.Admin.pCalendarService.country Country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditCountry", ReplyAction="http://tempuri.org/ICalendarService/EditCountryResponse")]
        System.Threading.Tasks.Task<bool> EditCountryAsync(pCalendar.WinForm.Admin.pCalendarService.country Country);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetCalendarsList", ReplyAction="http://tempuri.org/ICalendarService/GetCalendarsListResponse")]
        pCalendar.WinForm.Admin.pCalendarService.calendar[] GetCalendarsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetCalendarsList", ReplyAction="http://tempuri.org/ICalendarService/GetCalendarsListResponse")]
        System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.calendar[]> GetCalendarsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddCalendar", ReplyAction="http://tempuri.org/ICalendarService/AddCalendarResponse")]
        int AddCalendar(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddCalendar", ReplyAction="http://tempuri.org/ICalendarService/AddCalendarResponse")]
        System.Threading.Tasks.Task<int> AddCalendarAsync(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditCalenadr", ReplyAction="http://tempuri.org/ICalendarService/EditCalenadrResponse")]
        bool EditCalenadr(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditCalenadr", ReplyAction="http://tempuri.org/ICalendarService/EditCalenadrResponse")]
        System.Threading.Tasks.Task<bool> EditCalenadrAsync(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetDayTypes", ReplyAction="http://tempuri.org/ICalendarService/GetDayTypesResponse")]
        pCalendar.WinForm.Admin.pCalendarService.dtype[] GetDayTypes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetDayTypes", ReplyAction="http://tempuri.org/ICalendarService/GetDayTypesResponse")]
        System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.dtype[]> GetDayTypesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetHolidaysList", ReplyAction="http://tempuri.org/ICalendarService/GetHolidaysListResponse")]
        pCalendar.WinForm.Admin.pCalendarService.holiday[] GetHolidaysList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetHolidaysList", ReplyAction="http://tempuri.org/ICalendarService/GetHolidaysListResponse")]
        System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.holiday[]> GetHolidaysListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddHoliday", ReplyAction="http://tempuri.org/ICalendarService/AddHolidayResponse")]
        int AddHoliday(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddHoliday", ReplyAction="http://tempuri.org/ICalendarService/AddHolidayResponse")]
        System.Threading.Tasks.Task<int> AddHolidayAsync(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditHoliday", ReplyAction="http://tempuri.org/ICalendarService/EditHolidayResponse")]
        bool EditHoliday(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditHoliday", ReplyAction="http://tempuri.org/ICalendarService/EditHolidayResponse")]
        System.Threading.Tasks.Task<bool> EditHolidayAsync(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetRegionsList", ReplyAction="http://tempuri.org/ICalendarService/GetRegionsListResponse")]
        pCalendar.WinForm.Admin.pCalendarService.region[] GetRegionsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/GetRegionsList", ReplyAction="http://tempuri.org/ICalendarService/GetRegionsListResponse")]
        System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.region[]> GetRegionsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddRegion", ReplyAction="http://tempuri.org/ICalendarService/AddRegionResponse")]
        int AddRegion(pCalendar.WinForm.Admin.pCalendarService.region Region);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/AddRegion", ReplyAction="http://tempuri.org/ICalendarService/AddRegionResponse")]
        System.Threading.Tasks.Task<int> AddRegionAsync(pCalendar.WinForm.Admin.pCalendarService.region Region);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditRegion", ReplyAction="http://tempuri.org/ICalendarService/EditRegionResponse")]
        bool EditRegion(pCalendar.WinForm.Admin.pCalendarService.region Region);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalendarService/EditRegion", ReplyAction="http://tempuri.org/ICalendarService/EditRegionResponse")]
        System.Threading.Tasks.Task<bool> EditRegionAsync(pCalendar.WinForm.Admin.pCalendarService.region Region);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalendarServiceChannel : pCalendar.WinForm.Admin.pCalendarService.ICalendarService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalendarServiceClient : System.ServiceModel.ClientBase<pCalendar.WinForm.Admin.pCalendarService.ICalendarService>, pCalendar.WinForm.Admin.pCalendarService.ICalendarService {
        
        public CalendarServiceClient() {
        }
        
        public CalendarServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalendarServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalendarServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalendarServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public pCalendar.WinForm.Admin.pCalendarService.country[] GetCountriesList() {
            return base.Channel.GetCountriesList();
        }
        
        public System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.country[]> GetCountriesListAsync() {
            return base.Channel.GetCountriesListAsync();
        }
        
        public int AddCountry(pCalendar.WinForm.Admin.pCalendarService.country Country) {
            return base.Channel.AddCountry(Country);
        }
        
        public System.Threading.Tasks.Task<int> AddCountryAsync(pCalendar.WinForm.Admin.pCalendarService.country Country) {
            return base.Channel.AddCountryAsync(Country);
        }
        
        public bool EditCountry(pCalendar.WinForm.Admin.pCalendarService.country Country) {
            return base.Channel.EditCountry(Country);
        }
        
        public System.Threading.Tasks.Task<bool> EditCountryAsync(pCalendar.WinForm.Admin.pCalendarService.country Country) {
            return base.Channel.EditCountryAsync(Country);
        }
        
        public pCalendar.WinForm.Admin.pCalendarService.calendar[] GetCalendarsList() {
            return base.Channel.GetCalendarsList();
        }
        
        public System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.calendar[]> GetCalendarsListAsync() {
            return base.Channel.GetCalendarsListAsync();
        }
        
        public int AddCalendar(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar) {
            return base.Channel.AddCalendar(Calendar);
        }
        
        public System.Threading.Tasks.Task<int> AddCalendarAsync(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar) {
            return base.Channel.AddCalendarAsync(Calendar);
        }
        
        public bool EditCalenadr(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar) {
            return base.Channel.EditCalenadr(Calendar);
        }
        
        public System.Threading.Tasks.Task<bool> EditCalenadrAsync(pCalendar.WinForm.Admin.pCalendarService.calendar Calendar) {
            return base.Channel.EditCalenadrAsync(Calendar);
        }
        
        public pCalendar.WinForm.Admin.pCalendarService.dtype[] GetDayTypes() {
            return base.Channel.GetDayTypes();
        }
        
        public System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.dtype[]> GetDayTypesAsync() {
            return base.Channel.GetDayTypesAsync();
        }
        
        public pCalendar.WinForm.Admin.pCalendarService.holiday[] GetHolidaysList() {
            return base.Channel.GetHolidaysList();
        }
        
        public System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.holiday[]> GetHolidaysListAsync() {
            return base.Channel.GetHolidaysListAsync();
        }
        
        public int AddHoliday(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday) {
            return base.Channel.AddHoliday(Holiday);
        }
        
        public System.Threading.Tasks.Task<int> AddHolidayAsync(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday) {
            return base.Channel.AddHolidayAsync(Holiday);
        }
        
        public bool EditHoliday(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday) {
            return base.Channel.EditHoliday(Holiday);
        }
        
        public System.Threading.Tasks.Task<bool> EditHolidayAsync(pCalendar.WinForm.Admin.pCalendarService.holiday Holiday) {
            return base.Channel.EditHolidayAsync(Holiday);
        }
        
        public pCalendar.WinForm.Admin.pCalendarService.region[] GetRegionsList() {
            return base.Channel.GetRegionsList();
        }
        
        public System.Threading.Tasks.Task<pCalendar.WinForm.Admin.pCalendarService.region[]> GetRegionsListAsync() {
            return base.Channel.GetRegionsListAsync();
        }
        
        public int AddRegion(pCalendar.WinForm.Admin.pCalendarService.region Region) {
            return base.Channel.AddRegion(Region);
        }
        
        public System.Threading.Tasks.Task<int> AddRegionAsync(pCalendar.WinForm.Admin.pCalendarService.region Region) {
            return base.Channel.AddRegionAsync(Region);
        }
        
        public bool EditRegion(pCalendar.WinForm.Admin.pCalendarService.region Region) {
            return base.Channel.EditRegion(Region);
        }
        
        public System.Threading.Tasks.Task<bool> EditRegionAsync(pCalendar.WinForm.Admin.pCalendarService.region Region) {
            return base.Channel.EditRegionAsync(Region);
        }
    }
}
