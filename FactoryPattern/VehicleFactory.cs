using System;
using System.Runtime.ConstrainedExecution;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numOfTires)
        {
            switch (numOfTires)
            {
                case 2:
                    return new Dirtbike();
                case 3:
                    return new Trike();
                default:
                    return new Dirtbike();
            }
        }
    }
}

