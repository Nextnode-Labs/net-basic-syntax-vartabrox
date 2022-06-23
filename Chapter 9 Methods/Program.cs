// Methods are reusable code blocks that will only execute when called.

using System;

class Methods { 
    static void Main() { // program entry point

        Console.WriteLine("--- Calling Methods ---");

        Methods mtds = new Methods();
        mtds.PrintMe(); // called method

        Console.WriteLine("--- Method Parameters ---");
        mtds.PrintMe2("Veni ", "vidi ", "vici");

        Console.WriteLine("--- Params Keyword ---");
        string[] str = {"Summer", "Autumn", "Winter", "Spring"};
        mtds.PrintMe3(str);

        Console.WriteLine("--- Method Overloading ---");
        mtds.PrintMe4("Fox");
        mtds.PrintMe4("Bear ", "Elephant");
        mtds.PrintMe4("Zebra ", "Parrot ", "Crocodile");

        Console.WriteLine("--- Optional Paramaters ---");
        mtds.Math(7, 8);

        Console.WriteLine("--- Named Arguments ---");
        mtds.Math(i: 7, 2);

        Console.WriteLine("--- Return Statement ---");
        Console.WriteLine(mtds.GetCountry());

        Console.WriteLine("--- Pass by Value ---");
        int num = 3; // value type
        mtds.PassV(num); // pass value of num
        Console.WriteLine(num);

        Console.WriteLine("--- Pass by Reference ---");
        int[] y = {0}; // reference type
        mtds.PassRef(y); // pass object reference
        Console.WriteLine(y[0]);

        Console.WriteLine("--- Ref Keyword ---");
        int c = 15; // value type
        mtds.PassValRef(ref c); // pass reference to value type
        Console.WriteLine(c);

        RefKeyword r = new RefKeyword();
        ref int iReference = ref r.GetSpace(); // reference
        int iValue = r.GetSpace(); // value copy
        iReference = 12;
        Console.WriteLine(r.space);

        Console.WriteLine("--- Out Keyword ---");
        int m2; // value type
        mtds.PassOut(out m2); // pass the reference to unset value type
        mtds.PassOut(out int m3); // declare out variables in the argument list of a method call
        Console.WriteLine($"{m2} + {m3}");

        Console.WriteLine("--- Local Methods (recursive) ---");
        mtds.Counter();
       
    }

    void PrintMe() { // created method
        Console.WriteLine("Method successfully called");
    }
    // method parameters
    void PrintMe2(string m1, string m2, string m3) {
        Console.WriteLine(m1+m2+m3);
    }
    // params keyword
    void PrintMe3(params string[] z) {
        foreach (string x in z)
            Console.WriteLine(x);
    }
    //method overloading
    void PrintMe4(string a) {
        Console.WriteLine(a);
    }

    void PrintMe4(string b, string c) {
        Console.WriteLine(b + c);
    }

    void PrintMe4(string d, string e, string f) {
        Console.WriteLine(d + e + f);
    }

    // optional parameters and named arguments
    void Math(int i, int t, int h = 0) { // int h - is optional parameters
        Console.WriteLine(t*2+i*6-h*1);
    }

    // return statement
    string GetCountry() {
        return "Argentina";
    }

    void MethodReturn(){
        return;
    }

    // pass by value
    void PassV(int num2) {
        num2 = 25;
    }

    // pass by reference
    void PassRef(int[] b) {
        b = new int[] {10};
    }

    // ref keyword
    void PassValRef(ref int s) {
        s = 19;
    }

    // out keyword
    void PassOut(out int m) { 
        m = 50;
    }

    // local method
    void Counter() {
        int count = 9;
        RecursionMethod(count);
        Console.WriteLine("OK");
        void RecursionMethod(int count2) {
            if (count2 <= 0) return;
            Console.WriteLine(count2);
            System.Threading.Thread.Sleep(1000); // wait 1 second
            RecursionMethod(count2 - 1);     
        }
    }
}

// ref keyword new class
class RefKeyword {
    public int space = 9;
    public ref int GetSpace() {
        return ref space;
    }
}
