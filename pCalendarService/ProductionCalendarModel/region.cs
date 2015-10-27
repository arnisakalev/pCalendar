using System.ComponentModel.DataAnnotations;

namespace ProductionCalendarModel
{
    /// <summary>
    /// Справочник регионов по странам
    /// </summary>
    public class region
    {
        // Primary key        
        public short RegionId { get; set; }
        [Required]
        public string RegionName { get; set; }
        [Required] // Foreign key
        public short CountryId { get; set; }
    }
}
