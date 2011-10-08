using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using QLSV_WCF_Lib;

namespace Host {
    internal class Program {
        private static void Main() {
            var host = new ServiceHost(typeof (Service1));
            host.Open();

            Console.WriteLine("WCF Host is running");

            foreach (ServiceEndpoint endpoint in host.Description.Endpoints)
                Console.WriteLine("- {0}", endpoint.Address);

            Console.WriteLine();
            Console.WriteLine("Press ENTER to shutdown the host!");
            Console.ReadLine();

            host.Close();
        }
    }
}