using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WcfContract;

namespace WcfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri BaseAddress = new Uri("http://localhost:8080/main");
            ServiceHost host = new ServiceHost(typeof(Service1), BaseAddress);
            try
            {
                WSHttpBinding binding = new WSHttpBinding();
                host.AddServiceEndpoint(typeof(IService1), binding, "endpoint1");
                ServiceMetadataBehavior smb = new ServiceMetadataBehavior
                {
                    HttpGetEnabled = true
                };
                host.Description.Behaviors.Add(smb);
                host.Open();
                Console.WriteLine("Service1 uruchomiony\n");
                Console.ReadLine();
                Console.WriteLine("Zamykam...");
                host.Close();
            }
            catch (CommunicationException e)
            {
                Console.Write("exception: {0}", e.Message);
                host.Abort();
                Console.ReadLine();
                Console.WriteLine("Zamykam...");
            }
        }
    }
}
