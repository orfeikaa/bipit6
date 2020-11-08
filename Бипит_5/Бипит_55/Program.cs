using System;
//using System.ServiceModel;
using Бипит_5;

namespace Бипит_55
{
    class Program
    {
        static void Main(string[] args)
        {
            using (System.ServiceModel.ServiceHost serviceHost = new System.ServiceModel.ServiceHost(typeof(Service1)))
            {
                serviceHost.Open();
                Console.WriteLine("Сервис запущен...");
                Console.WriteLine("Нажмите любую клавишу для остановки...");
                Console.ReadKey();
            }
        }
    }
}
