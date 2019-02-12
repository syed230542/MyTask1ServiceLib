using System;
using System.ServiceModel;

namespace MyTask1ServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost svcHost = null;
            try
            {
                //Configuraion in Web.Config file. 
                svcHost = new ServiceHost(typeof(MyTask1ServiceLib.GreetingService));
                svcHost.Open();
                Console.WriteLine("\n\nService is Running  at following address");
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                svcHost = null;
                Console.WriteLine("Service can not be started \n\nError Message [" + ex.Message + "]");
                Console.ReadLine();
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
