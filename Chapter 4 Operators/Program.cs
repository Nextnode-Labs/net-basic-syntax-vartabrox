// Operators are used to perform operations on variables and values
using System;

class ArithmeticOperators {
    static void Main() {
        
    Console.WriteLine("--- Arithmetic Operators ---");

    int add = 14 + 32; // addition 
    Console.WriteLine("Addition: 14 + 32 = " + add);

    int sub = 27 - 54; // Subtraction 
    Console.WriteLine("Subtraction: 27 - 54 = " + sub);

    int mul = 9 * 9; // Multiplication 
    Console.WriteLine("Multiplication: 9 * 9 = " + mul);

    float div = 7 / (float)2; // Division 
    Console.WriteLine("Division: 7 / 2 = " + div);

    int mod = 5 % 3; // Modulus 
    Console.WriteLine("Modulus: 5 % 3 = " + mod);
    
    int inc = 9;
    int inc2 = ++inc; // Increment 
    Console.WriteLine("Increment: ++9 = " + inc2);

    int dec = 7;
    int dec2 = --dec; // Decrement Prefix
    Console.WriteLine("Decrement: --7 = " + dec2);

    int decTest = 7;
    int decTest2 = decTest--; // Decrement Postfix
    Console.WriteLine("Decrement Postfix: 7 -- = " + decTest2);
    Console.WriteLine("Postfix decrement: " + decTest); // Just testing the differences between postfix and prefix decrements

    int a = 32, b = 4, c = 11;
    double d = 13.8;
    double e = (a + b - c)/d;
    Console.WriteLine("Three operators in one example:");
    Console.WriteLine("({0} + {1} - {2}) / {3} = {4}", a, b, c, d, e);

    Console.WriteLine("--- Comparison Operators ---");

    bool boolComp = (24 == 24); // equal to (true)
    Console.WriteLine("24 equal to 24: " + boolComp);

    boolComp = (21 != 3); // equal to (true)
    Console.WriteLine("21 not equal to 3: " + boolComp);

    boolComp = (11 > 12); // greater than (false)
    Console.WriteLine("11 greater than 12: " + boolComp);

    boolComp = (146 < 233); // less than (true)
    Console.WriteLine("146 less than 233: " + boolComp);

    boolComp = (34 >= 35); // greater than or equal to (false)
    Console.WriteLine("34 greater than or equal to 35: " + boolComp);

    boolComp = (7 <= 99); // less than or equal to (true)
    Console.WriteLine("7 less than or equal to 99: " + boolComp);

    Console.WriteLine("--- Assignment Operators ---");

    int i, i1, i2, i3; //assignment
    i = i1 = i2 = i3 = 88;
    double i4 = 88;
    Console.WriteLine("i, i1, i2, i3, i4 = " + i);

    i += 4; // i = i + 4 Assignment after addition
    Console.WriteLine("i += 4 Assignment after addition: " + i);

    i1 -= 17; // i1 = i1 - 17 Assignment after subtraction
    Console.WriteLine("i1 -= 17 Assignment after subtraction: " + i1);

    i2 *= 7; // i2 = i2 * 7 Assignment after multiplication
    Console.WriteLine("i2 *= 7 Assignment after multiplication: " + i2);

    i3 %= 9; // i3 = i3 % 9 Assignment after modulus
    Console.WriteLine("i3 %= 9 Assignment after modulus: " + i3);

    i4 /= 12; // i4 = i4 / 12 Assignment after division
    Console.WriteLine("i4 /= 12 Assignment after division: " + i4);

    Console.WriteLine("--- Logical Operators ---");

    bool logic = (true && true); // logical and (true)
    Console.WriteLine("(logical and) (true && true) = " + logic);

    logic = (false || false); // logical or (false)
    Console.WriteLine("(logical or) (false && false) = " + logic);

    logic = !(false); // logival not (true)
    Console.WriteLine("(logical note) !(false) = " + logic);

    Console.WriteLine("--- Bitwise Operators ---");

    int bit = 60 & 13; // and &
    Console.WriteLine("and 60 & 13 = " + bit);

    bit = 60 | 13; // or |
    Console.WriteLine("or 60 | 13 = " + bit);

    bit = 60 ^ 13; // xor ^
    Console.WriteLine("xor 60 ^ 13 = " + bit);

    bit = 60 << 2; // left shift <<
    Console.WriteLine("left shift 60 << 13 = " + bit);

    bit = 60 >> 2; // right shift >>
    Console.WriteLine("right shift 60 >> 13 = " + bit);

    bit = ~60; // invert ~
    Console.WriteLine("invert ~60 " + bit);
    
    // testing shorthand assignment operators
    bit = 7;
    bit &= 9;
    Console.WriteLine(bit);

    // testing operator precendents

    Console.WriteLine("m = 13-2 < 3*5 && 9/3 == 5");
    bool m = 13-2 < 3*5 && 9/3 == 5;
    Console.WriteLine(m);

    }
}
