using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(ConcurrencyMode=ConcurrencyMode.Multiple)]
    public class Service1 : IService1
    {
        public void AsyncSay(string s)
        {
            Console.Write("{0} : async start", s);
            Thread.Sleep(3000);
            Console.Write("{0} : async stop", s);
            return;
        }

        public void Say(string s)
        {
            Console.Write("{0} : sync start", s);
            Thread.Sleep(3000);
            Console.Write("{0} : sync stop", s);
            return;
        }
    }
}
