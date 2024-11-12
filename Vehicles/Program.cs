namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car fordFiesta = new Car("Ford", "Fiesta");
            Motorcycle ducatti = new Motorcycle("Ducatti", "Monster", true);

            fordFiesta.StartEngine();
            ducatti.StartEngine();
            
            fordFiesta.Drive();
            ducatti.Drive();

        }
    }
}
