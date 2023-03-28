using System;
namespace FactoryPattern
{
	public class Dirtbike : IVehicle
	{
        public Dirtbike()
        {
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is drivin'...");
        }
    }
}