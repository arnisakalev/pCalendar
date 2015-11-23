using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ProductionCalendarModel;

namespace pCalendarService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CalendarService : ICalendarService
    {
        CalendarContext db = new ProductionCalendarModel.CalendarContext();

        public List<country> GetCountriesList()
        {
            return db.Countries.ToList<country>();
        }

        public int AddCountry(country Country)
        {
            throw new NotImplementedException();
        }

        public bool EditCountry(country Country)
        {
            throw new NotImplementedException();
        }

        public List<calendar> GetCalendarsList()
        {
            return db.Calendars.ToList<calendar>();
        }

        public int AddCalendar(calendar Calendar)
        {
            throw new NotImplementedException();
        }

        public bool EditCalenadr(calendar Calendar)
        {
            throw new NotImplementedException();
        }

        public List<dtype> GetDayTypes()
        {
            throw new NotImplementedException();
        }

        public List<holiday> GetHolidaysList()
        {
            throw new NotImplementedException();
        }

        public int AddHoliday(holiday Holiday)
        {
            throw new NotImplementedException();
        }

        public bool EditHoliday(holiday Holiday)
        {
            throw new NotImplementedException();
        }

        public List<region> GetRegionsList()
        {
            throw new NotImplementedException();
        }

        public int AddRegion(region Region)
        {
            throw new NotImplementedException();
        }

        public bool EditRegion(region Region)
        {
            throw new NotImplementedException();
        }
    }
}
