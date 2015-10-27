using System.ComponentModel.DataAnnotations;

namespace ProductionCalendarModel
{
    /// <summary>
    /// Таблица со списком календарей для разных стран
    /// </summary>
    public class calendar
    {
        // Primary key
        public short CalendarId { get; set; }
        [Required]
        public string CalendarName { get; set; }
        [Required] // Foreign key
        public short CountryId { get; set; }
    }
}
