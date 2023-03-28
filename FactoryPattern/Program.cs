namespace FactoryPattern
{
    public static class FactoryPattern
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of tires (2 or 3): ");
            int numOfTires;
            var input = int.TryParse(Console.ReadLine(), out numOfTires);

            IVehicle dirtbike = VehicleFactory.GetVehicle(2);
            dirtbike.Drive();

            IVehicle trike = VehicleFactory.GetVehicle(3);
            trike.Drive();
        }
    }
}
