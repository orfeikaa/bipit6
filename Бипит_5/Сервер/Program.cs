using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Бипит_5;

namespace Сервер
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------WCF-----------");
            using (ServiceHost serviceHost = new ServiceHost(typeof(Service1)))
            {
                serviceHost.Open();
                Console.WriteLine("Сервис запущен...");
                Console.WriteLine("Host Info ************");
                Console.WriteLine($"Name: {serviceHost.Description.ConfigurationName}");
                Console.WriteLine($"Port http: {serviceHost.BaseAddresses[0].Port}");
                Console.WriteLine($"Port tcp: {serviceHost.BaseAddresses[1].Port}");
                Console.WriteLine($"LocalPath http: {serviceHost.BaseAddresses[0].LocalPath}");
                Console.WriteLine($"LocalPath tcp: {serviceHost.BaseAddresses[1].LocalPath}");
                Console.WriteLine($"Uri http: {serviceHost.BaseAddresses[0].AbsoluteUri}");
                Console.WriteLine($"Uri tcp: {serviceHost.BaseAddresses[1].AbsoluteUri}");
                Console.WriteLine($"Sheme http: {serviceHost.BaseAddresses[0].Scheme}");
                Console.WriteLine($"Sheme tcp: {serviceHost.BaseAddresses[1].Scheme}");
                Console.WriteLine("**********************");
                Console.WriteLine("Нажмите Enter для остановки...");
                Console.ReadKey();
            }
        }

    }
}
