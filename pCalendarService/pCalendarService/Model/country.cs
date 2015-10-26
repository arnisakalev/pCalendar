using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace pCalendarService.Model
{
    class country
    {
        // Primary key
        public int CountryId { get; set; }
        [Required]
        public string CountryName { get; set; }
    }
}
