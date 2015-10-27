using System.Data.Entity;

namespace ProductionCalendarModel
{
    public class CalendarContext : DbContext
    {
        public DbSet<calendar> Calendars { get; set; }
        public DbSet<country> Countries { get; set; }
        public DbSet<region> Regions { get; set; }
        public DbSet<holiday> Holidays { get; set; }
        public DbSet<dtype> DayTypes { get; set; }
        public DbSet<region_holiday> HolidaysInRegion { get; set; }
        public DbSet<calendar_red_day> CalendarRedDays { get; set; }

        public CalendarContext()
        {
            Database.SetInitializer<CalendarContext>(new CalendarDbInitializer());
        }
    }
}
