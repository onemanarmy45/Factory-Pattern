using System;
namespace FactoryPattern
{
    public class Trike : IVehicle
    {
        public Trike()
        {
        }

        public void Drive()
        {
            Console.WriteLine("Ridin' the trike...");
        }
    }
}