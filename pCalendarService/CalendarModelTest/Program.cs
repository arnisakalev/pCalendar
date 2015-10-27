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
            //Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ProductionCalendarModel.CalendarContext;Integrated Security=True;MultipleActiveResultSets=True

            using (var db = new ProductionCalendarModel.CalendarContext())
            {
                //Console.Write("Press any key");
                //var cName = Console.ReadLine();

                //var newCalendar = new ProductionCalendarModel.country() { CountryName = "Россия" };
                //var newCalendar1 = new ProductionCalendarModel.country() { CountryName = "Беларусь" };

                //db.Countries.Add(newCalendar);
                //db.Countries.Add(newCalendar1);

                //var q = from c in db.Countries select c;

                //foreach (var item in q)
                //{
                //    Console.WriteLine(item.CountryName);
                //}

                //Console.ReadLine();

                //try
                //{
                //    db.SaveChanges();
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.ToString());
                //}                

            }
        }
    }
}
