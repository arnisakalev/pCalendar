using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;

namespace pCalendarServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = null;
            try
            {
                var service = new pCalendarService.CalendarService();
                svcHost = new ServiceHost(service);
                svcHost.Open();
            }
            catch (Exception ex)
            {
                svcHost = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + ex.Message + "]");
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
            }
            if (svcHost != null)
            {
                Console.WriteLine("\nPress any key to close the Service");
                Console.ReadKey();
                svcHost.Close();
                svcHost = null;
            }
        }
    }
}
