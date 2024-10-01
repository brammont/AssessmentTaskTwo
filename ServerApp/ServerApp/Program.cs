using System;
using System.ServiceModel;
using AstroMath;

namespace ServerApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Server App Started...");

			AstroMathFunctions mathFunctions = new AstroMathFunctions();

			double velocity = mathFunctions.StarVelocity(500.1, 500.0);
			Console.WriteLine($"Star Velocity: {velocity} m/s");

			double distance = mathFunctions.StarDistance(0.547);
			Console.WriteLine($"Star Distance: {distance} parsecs");

			double kelvin = mathFunctions.Kelvin(27);
			Console.WriteLine($"Temperature: {kelvin} K");

			double eventHorizon = mathFunctions.EventHorizon(8.2 * Math.Pow(10, 36));
			Console.WriteLine($"Event Horizon: {eventHorizon} meters");

			Console.ReadLine();
		}
	}
}
