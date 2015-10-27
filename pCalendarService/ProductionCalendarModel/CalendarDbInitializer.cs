using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionCalendarModel
{
    public class CalendarDbInitializer : DropCreateDatabaseAlways<CalendarContext>
    {
        protected override void Seed(CalendarContext context)
        {
            context.Countries.Add(new country() { CountryId = 1, CountryName = "Россия" });

            var calendars = new List<calendar>();
            calendars.Add(new calendar() { CalendarId = 1, CountryId = 1, CalendarName = "Производственный календарь при пятидневной рабочей неделе" });
            calendars.Add(new calendar() { CalendarId = 2, CountryId = 1, CalendarName = "Производственный календарь при шестидневной рабочей неделе" });
            context.Calendars.AddRange(calendars);

            var holidays = new List<holiday>();
            holidays.Add(new holiday() { HolidayId = 1, HolidayName = "Новогодние каникулы (в ред. Федерального закона от 23.04.2012 № 35-ФЗ)" });
            holidays.Add(new holiday() { HolidayId = 2, HolidayName = "Рождество Христово" });
            holidays.Add(new holiday() { HolidayId = 3, HolidayName = "День защитника Отечества" });
            holidays.Add(new holiday() { HolidayId = 4, HolidayName = "Международный женский день" });
            holidays.Add(new holiday() { HolidayId = 5, HolidayName = "Праздник Весны и Труда" });
            holidays.Add(new holiday() { HolidayId = 6, HolidayName = "День Победы" });
            holidays.Add(new holiday() { HolidayId = 7, HolidayName = "День России" });
            holidays.Add(new holiday() { HolidayId = 8, HolidayName = "День народного единства" });
            context.Holidays.AddRange(holidays);

            var dTypes = new List<dtype>();
            dTypes.Add(new dtype() { DTypeId = 1, DTypeName = "Выходной день" });
            dTypes.Add(new dtype() { DTypeId = 2, DTypeName = "Короткий день" });
            dTypes.Add(new dtype() { DTypeId = 3, DTypeName = "Рабочий день" });
            context.DayTypes.AddRange(dTypes);

            base.Seed(context);
        }
    }
}
