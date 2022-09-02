/* Events enable an object to notify other objects when something of interest 
occurs. The object that raises the event is called the publisher and the 
objects that handle the event are called subscribers */

#nullable disable
using static System.Console;

namespace Events
{
    class FuelTank
    {
        public delegate void PetrolTank(string message);
        public event PetrolTank GetMessage; // event definition

        public FuelTank(int fuel)
        {
            Fuel = fuel;
        }

        public int Fuel
        {
            get;
            private set;
        }

        public void AddFuel(int fuel)
        {
            Fuel += fuel;
            GetMessage?.Invoke($"The fuel tank received: {fuel}"); // event call
        }

        public void Consumption(int fuel)
        {
            if (Fuel >= fuel)
            {
                Fuel -= fuel;
                GetMessage?.Invoke($"Used: {fuel}"); // event call
            }
            else
            {
                GetMessage?.Invoke($"Not enough fuel. Everything in the tank: {fuel}");
            }
        }

        // handler management
        /* With the help of special add/remove accessors, 
        we can control adding and removing handlers. */

        public delegate void PetrolTank2(string message);
        public PetrolTank2 getmessage;

        public event PetrolTank2 GetMessage2
        {
            add
            {
                getmessage += value;
                WriteLine($"{value.Method.Name} added");
            }
            remove
            {
                getmessage -= value;
                WriteLine($"{value.Method.Name} deleted");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            WriteLine("--- Publisher, Event Keyword ---");

            FuelTank fueltank = new FuelTank(50);

            fueltank.GetMessage += PanelMessage; // add handler for event GetMessage
            fueltank.AddFuel(35); // add to fuel tank
            WriteLine($"Total in fuel tank: {fueltank.Fuel}");

            fueltank.Consumption(15); // add to fuel tank
            WriteLine($"Total in fuel tank: {fueltank.Fuel}");

            fueltank.Consumption(95); // add to fuel tank
            WriteLine($"Total in fuel tank: {fueltank.Fuel}");

            void PanelMessage(string message) => WriteLine(message);

            WriteLine("--- Subscribing to Events ---");

            fueltank.GetMessage += PanelGreenMessage; // add handler for event GetGreenMessage

            fueltank.AddFuel(12); // add to fuel tank
            WriteLine($"Total in fuel tank: {fueltank.Fuel}");

            fueltank.Consumption(7); // add to fuel tank
            WriteLine($"Total in fuel tank: {fueltank.Fuel}");

            fueltank.GetMessage -= PanelGreenMessage; // delete handler for event GetGreenMessage
            fueltank.AddFuel(17); // add to fuel tank

            void PanelGreenMessage(string message)
            {
                ForegroundColor = ConsoleColor.Green; // set green color
                WriteLine(message);
                ResetColor();
            }

            WriteLine("--- Handler management ---");

            FuelTank fueltank2 = new FuelTank(55);

            fueltank2.GetMessage2 += PanelMessage;
            fueltank2.AddFuel(22);

            fueltank2.GetMessage2 -= PanelMessage;
            fueltank2.AddFuel(33);
        }
    }
}
