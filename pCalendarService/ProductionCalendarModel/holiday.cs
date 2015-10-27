using System.ComponentModel.DataAnnotations;

namespace ProductionCalendarModel
{
    /// <summary>
    /// Справочник праздников
    /// </summary>
    public class holiday
    {
        public short HolidayId { get; set; }
        [Required]
        public string HolidayName { get; set; }
    }
}
