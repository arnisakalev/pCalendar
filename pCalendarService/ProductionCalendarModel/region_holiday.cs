using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductionCalendarModel
{
    /// <summary>
    /// Справочник праздников в регионах
    /// </summary>
    public class region_holiday
    {
        [Key, Column(Order = 0)]
        public short RegionId { get; set; }
        [Key, Column(Order = 1)]
        public short HolidayId { get; set; }
    }
}
