using System.ComponentModel.DataAnnotations;

namespace ProductionCalendarModel
{
    /// <summary>
    /// Справочник стран
    /// </summary>
    public class country
    {
        // Primary key
        public short CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
