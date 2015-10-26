using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace pCalendarService.Model
{
    class region
    {
        // Primary key
        public int RegionId { get; set; }
        [Required]
        public string RegionName { get; set; }
        [Required] // Foreign key
        public int CountryId { get; set; }
    }
}
