using System;

/** In C#, thete are different types of variables: 
int, double, char, string, bool, etc. */
class Variables
{
    static void Main() 
    {
        System.Console.WriteLine("Declaration and assignment variables");
        int myInt; 
        myInt = 234;
        /* The declaration and assignment 
        can be combined into a single statement */
        int myInt2 = 124;
        System.Console.WriteLine("Just variable: " + myInt);
        System.Console.WriteLine("Another one: " + myInt2);

        System.Console.WriteLine("Signed Integers");
        sbyte sbyteInt = -50; // -128 to +127
        short shortInt = 27546; // -32768 to +32767
        int intInt = 124234; // -2^31 to +2^31-1
        long longInt = 325689756; // -2^63 to +2^63-1
        System.Console.WriteLine("sbyte: " + sbyteInt);
        System.Console.WriteLine("short: " + shortInt);
        System.Console.WriteLine("int: " + intInt);
        System.Console.WriteLine("long: " + longInt);

        System.Console.WriteLine("Unsigned integers (only positive values)");
        byte byteInt = 254; // 0 to 255
        ushort ushortInt = 59000; // 0 to 65535
        uint uintInt = 123876; // 0 to 2^32-1
        ulong ulongInt = 34023423; // 0 to 2^64-1
        System.Console.WriteLine("byte: " + byteInt);
        System.Console.WriteLine("ushort: " + ushortInt);
        System.Console.WriteLine("uint: " + uintInt);
        System.Console.WriteLine("ulong: " + ulongInt);

        System.Console.WriteLine("Hexademical and binary notaions");
        int hexNumber = 0xF; // 15 in hexadecimal
        int binNumber = 0b0100; // 4 in binary
        System.Console.WriteLine("hexademical: " + hexNumber);
        System.Console.WriteLine("binary: " + binNumber);

        System.Console.WriteLine("Floating-Point Types");
        float floatLab = 1.8F; 
        double doubleLab = 2.9;
        decimal decimalLab = 2.5M;
        System.Console.WriteLine("float: " + floatLab);
        System.Console.WriteLine("double: " + doubleLab);
        System.Console.WriteLine("decimal: " + decimalLab);

        System.Console.WriteLine("Char Type");
        char charVar = 'A'; // Unicode char
        System.Console.WriteLine("char: " + charVar);

        System.Console.WriteLine("Bool Type");
        bool boolVar =  true; // can be either true or false
        System.Console.WriteLine("bool: " + boolVar);

        System.Console.WriteLine("String type");
        string stringVar = "The sky is blue!"; // String values are surrounded by double quotes
        System.Console.WriteLine("string: " + stringVar);
    }
}