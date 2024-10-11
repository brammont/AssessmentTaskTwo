using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using AstroMaths;

namespace AstroService
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting WCF Service...");
            Uri baseAddress = new Uri("net.pipe://localhost/AstroService");

            using (ServiceHost host = new ServiceHost(typeof(AstroServer), baseAddress))
            {
                NetNamedPipeBinding binding = new NetNamedPipeBinding();
                host.AddServiceEndpoint(typeof(IAstroContract), binding, "AstroPipe");

                try
                {
                    host.Open();
                    Console.WriteLine("Service is running... Press Enter to exit.");
                    Console.ReadLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error while server started" + ex.Message);
                }
            }
        }
    }
}
