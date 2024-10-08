using System;
using System.ServiceModel;
using AstroMath;

namespace ServerApp
{
	// This class implements the service contract IAstroContract
	public class AstroServer : IAstroContract
	{
		private AstroMathFunctions mathFunctions = new AstroMathFunctions();

		// Implement the StarVelocity method
		public double StarVelocity(double observedWavelength, double restWavelength)
		{
			return mathFunctions.StarVelocity(observedWavelength, restWavelength);
		}

		// Implement the StarDistance method
		public double StarDistance(double parallaxAngle)
		{
			return mathFunctions.StarDistance(parallaxAngle);
		}

		// Implement the Kelvin method
		public double Kelvin(double celsius)
		{
			return mathFunctions.Kelvin(celsius);
		}

		// Implement the EventHorizon method
		public double EventHorizon(double blackHoleMass)
		{
			return mathFunctions.EventHorizon(blackHoleMass);
		}
	}
}
