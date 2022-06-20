/* There are four looping structures in C#. These are used to execute a code
block multiple times. */

using System;

class Loops {
    static void Main() {

        Console.WriteLine("--- While Loop ---");

        int numbers = 0;
        while (numbers <= 49) {
            Console.Write(numbers++ + " "); // will display values 0-49
        }

        Console.WriteLine(Environment.NewLine + "--- Do-While Loop ---");
        
        int numbers2 = 0;
        do {
            Console.Write(numbers2++ + " "); // will display values 0-19
        } while (numbers2 <= 19);

        Console.WriteLine(Environment.NewLine + "--- For Loop ---");

        for (int numbers3 = 7; numbers3 < 21; numbers3++) {
            Console.Write(numbers3 + " "); // will display values 7-20
        }
        Console.WriteLine(" - example 1");

        for (int x = 0, y = 19; x < 29; x++, y--) {
            Console.Write(x-y + " "); // will display values -19-37
        }
        Console.WriteLine(" - example 2");

        for (int z = 9; z > 0;) {
            Console.Write(z-- + " ");  // will display values 9-1 
        }
        Console.Write(" - example 3");

        Console.WriteLine(Environment.NewLine + "--- Foreach Loop ---");

        string[] week = {"Mon", "Thue", "Wed", "Thurs", "Fri", "Sat", "Sun"};
        foreach (string days in week) {
            Console.WriteLine(days + " "); // will display days of the week
        }

        Console.WriteLine("--- Break and Continue ---");
               
        for (int numbers4 = 19; numbers4 >= 9; numbers4--) {
            if (numbers4 == 16) continue; // start next iteration
            if (numbers4 == 11) break; // end loop
            Console.WriteLine(numbers4); // will display 19, 18, 17, 15-12
        }
    }
}
