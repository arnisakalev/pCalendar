using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProductionCalendarModel;

namespace pCalendarService
{
    [ServiceContract]
    public interface ICalendarService
    {

        #region Работа со списком стран
        [OperationContract]
        List<country> GetCountriesList();

        [OperationContract]
        int AddCountry(country Country);

        [OperationContract]
        bool EditCountry(country Country);
        #endregion

        #region Работа со списком кадендарей
        [OperationContract]
        List<calendar> GetCalendarsList();

        [OperationContract]
        int AddCalendar(calendar Calendar);

        [OperationContract]
        bool EditCalenadr(calendar Calendar);
        #endregion

        #region Работа со списком типов дней
        [OperationContract]
        List<dtype> GetDayTypes();
        #endregion

        #region Работа со списком праздников
        [OperationContract]
        List<holiday> GetHolidaysList();

        [OperationContract]
        int AddHoliday(holiday Holiday);

        [OperationContract]
        bool EditHoliday(holiday Holiday);
        #endregion

        #region Работа со списком регионов
        [OperationContract]
        List<region> GetRegionsList();

        [OperationContract]
        int AddRegion(region Region);

        [OperationContract]
        bool EditRegion(region Region);
        #endregion

        #region Работа с праздниками в регионе

        #endregion





        //[OperationContract]
        //string GetData(int value);

        //[OperationContract]
        //CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }

    //// Use a data contract as illustrated in the sample below to add composite types to service operations.
    //[DataContract]
    //public class CompositeType
    //{
    //    bool boolValue = true;
    //    string stringValue = "Hello ";

    //    [DataMember]
    //    public bool BoolValue
    //    {
    //        get { return boolValue; }
    //        set { boolValue = value; }
    //    }

    //    [DataMember]
    //    public string StringValue
    //    {
    //        get { return stringValue; }
    //        set { stringValue = value; }
    //    }
    //}
}
