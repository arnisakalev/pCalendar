using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace pCalendarService.Model
{
    class calendar
    {
        // Primary key
        public int CalendarId { get; set; }
        [Required]
        public string CalendarName { get; set; }
        [Required] // Foreign key
        public int CountryId { get; set; }
    }
}
