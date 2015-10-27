using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionCalendarModel
{
    public class calendar_red_day
    {
        [Key, Column(Order = 0)]
        public DateTime RedDayId { get; set; }
        [Key, Column(Order = 1)]
        public short CalendarId { get; set; }
        public short DTypeId { get; set; }
        public short HolidayId { get; set; }
    }
}
