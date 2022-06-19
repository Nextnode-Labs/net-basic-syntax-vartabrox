/* Conditional statements are used to execute different code blocks based on
different conditions. */

using System;

class Conditionals {
    static void Main () {
        Console.WriteLine("--- if Statement ---");

        int random = new System.Random().Next(2022);// Get a random integer (from 0 to 2022)
        
        Console.WriteLine(random + " - random number from 0 to 2022"); // Output value

        if (random > 1268) { 
            Console.WriteLine(random + " > 1268 - condition inside the parentheses is evaluated to true");
        }
        else if (random <= 456) {
            Console.WriteLine(random + " is less than or equal 456");
        }
        else {
            Console.WriteLine("The number {0} is greater than 456 but less than 1268", random);
        }

        Console.WriteLine("--- Switch Statement ---");

        int randoms = new System.Random().Next(5);
        Console.WriteLine(randoms + " - random number from 0 to 5"); // Get a random integer (from 0 to 5)

        switch (randoms) {
            case 1:
                Console.WriteLine("Case 1");
                break;
            case 2: // if the case clause is completely empty, allowed to fall through to the next label  
            case 3:
                Console.WriteLine("Case 3");
                goto case 4; // jump to the case 4
            case 4:
                Console.WriteLine("Case 4");
                break;
            case 0:
                default:
                    Console.WriteLine("Case 0");
                    break;
        }

        Console.WriteLine("--- Switch Expression ---");

        int y = new System.Random().Next(9); 
        Console.WriteLine(y + " - random number from 0 to 9"); // Get a random integer (from 0 to 9)

        string result = y switch {
            0 => "zero",
            1 => "one",
            2 => "two",
            3 => "free",
            _ => "more then free"
            
        };

        Console.WriteLine("random number is " + result);

        Console.WriteLine("--- Ternary Operator ---");

        double x = new System.Random().NextDouble();
        Console.WriteLine(x + " - random number from 0.0 to 1.0");
        x = (x < 0.5) ? 0 : 1; 
        Console.WriteLine(x + " - if the number is greater than 0.5, then the value is rounded up to 1.");
    }
}
    
