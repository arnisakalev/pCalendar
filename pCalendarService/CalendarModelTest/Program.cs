using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarModelTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ProductionCalendarModel.CalendarContext())
            {
                var q = from c in db.Countries select c;

                foreach (var item in q)
                {
                    Console.WriteLine(item.CountryName);
                }
            }
        }
    }
}
