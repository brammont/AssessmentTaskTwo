using System.ServiceModel;

namespace ServerApp
{
	// Define a service contract for WCF
	[ServiceContract]
	public interface IAstroContract
	{
		[OperationContract]
		double StarVelocity(double observedWavelength, double restWavelength);

		[OperationContract]
		double StarDistance(double parallaxAngle);

		[OperationContract]
		double Kelvin(double celsius);

		[OperationContract]
		double EventHorizon(double blackHoleMass);
	}
}
