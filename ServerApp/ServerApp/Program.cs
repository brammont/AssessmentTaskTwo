using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;


namespace ServerApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Starting WCF Service...");

			// Host the WCF service using the AstroServer implementation
			using (ServiceHost host = new ServiceHost(typeof(AstroServer)))
			{
				// Configure the service with basic HTTP binding and NetNamedPipeBinding
				host.AddServiceEndpoint(typeof(IAstroContract), new BasicHttpBinding(), "http://localhost:8080/AstroService");

				// Enable service metadata for HTTP GET requests
				ServiceMetadataBehavior smb = new ServiceMetadataBehavior
				{
					HttpGetEnabled = true,
					HttpGetUrl = new Uri("http://localhost:8080/AstroService/mex")
				};
				host.Description.Behaviors.Add(smb);

				// Start the service
				host.Open();
				Console.WriteLine("Service is running... Press Enter to exit.");
				Console.ReadLine();
			}
		}
	}
}
