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
    }    
}
