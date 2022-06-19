/* Arrays
An array is a data structure used for storing a collection of values that all 
have the same data type. */

using System;

class Arrays {
    static void Main () {

        string[] cars1 = new string[4]; // The first way to create arrays
        cars1[0] = "Volvo";
        cars1[1] = "Ford";
        cars1[2] = "BMW";
        cars1[3] = "GMC";
        
        int[] numbers; // The second way to create arrays
        numbers = new int[3];
        numbers[0] = 1;
        numbers[1] = 2;
        numbers[2] = 3;

        string[] cars; // The third way to create arrays
        cars = new string[3]{"Mazda", "Nissan", "Suzuki"};

        string[] laptops = new string[] {"Panasonic", "Apple", "Lenovo"}; // The fourth way to create arrays
        
        Console.WriteLine("--- Array Access ---");

        Console.WriteLine(laptops[0]);
        Console.WriteLine(laptops[1]);
        Console.WriteLine(laptops[2]);

        Console.WriteLine(cars[1]);

        Console.WriteLine(cars1[3]);
        Console.WriteLine(cars.Length + "- get the length of the array"); // Get the length of the array
        Console.WriteLine(numbers[0]);

        string[,] y = new string[2, 3]{{"Red", "Green", "Blue"}, {"Black", "Yellow", "Pink"}}; // rectangular arrays
            foreach (string x in y)
                Console.Write($"{x} " + "/n");

       // Console.WriteLine("--- Jagged Arrays ---");

        string[][] eat = new string[2][];
        eat[0] = new string[]{"orange"};
        eat[1] = new string[]{"cherry", "apple"};

    }
}
