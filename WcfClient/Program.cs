using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WcfClient.ServiceReference1;

namespace WcfClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1Client client = new Service1Client("WSHttpBinding_IService1");
            Console.WriteLine("Wywoluje funkcje 1: ");
            client.Say("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("Kontynuacja po funkcji 1: ");
            Console.Write("Wywoluje funkcje 2: ");
            client.AsyncSay("Klient1");
            Thread.Sleep(10);
            Console.WriteLine("Kontynuacja po funkcji 2");
            client.Close();
            Console.WriteLine("Koniec client");
        }
    }
}
