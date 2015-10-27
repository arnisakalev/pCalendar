using System.ComponentModel.DataAnnotations;

namespace ProductionCalendarModel
{
    /// <summary>
    /// Справочник типов дней
    /// </summary>
    public class dtype
    {
        public short DTypeId { get; set; }
        [Required]
        public string DTypeName { get; set; }
    }
}
