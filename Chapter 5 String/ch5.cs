/* The string data type is used to store string constants. They are delimited by
double quotes. */
using System;

class Strings {
    static void Main() {

    Console.WriteLine("--- The string data type ---");
    string str = "Summer 2022"; // Summer 2022
    Console.WriteLine("{0} is the string data type", str);

    Console.WriteLine("--- String Concatenation ---");
    string newStr = str + " is not hot"; // Summer 2022 is not hot
    Console.WriteLine(newStr);

    str += " is not hot"; // accompanying assignment operator
    Console.WriteLine(str + " - accompanying assignment operator +=");

    int y = 7;
    string strInt = y + " is " + 7; // 7 is 7
    Console.WriteLine(strInt + " - implicitly convert the non-string type into a string");

    string d = y.ToString() + " is " + 7.ToString(); // 7 is 7
    Console.WriteLine(d + " - string conversion can also be made explicitly with ToString() method ");

    string str1 = "Summer";
    string str2 = "2022";
    //string str3 = $"{str1} {str2}"; // Summer 2022
    //Console.WriteLine(str3);

    Console.WriteLine("--- Escape Characters ---");

    string strEscape
        = "Summer " + 
          "2022";
    Console.WriteLine(strEscape + "- a statement can be broken up across multiple lines");

    strEscape = "Summer\n2022";
    Console.WriteLine(strEscape + @"- to add new lines into the string itself, the escape character \n ");

    strEscape = "Summer\t2022";
    Console.WriteLine(strEscape + @"- to add horizontal tab \t ");

    strEscape = "Summer\v2022";
    Console.WriteLine(strEscape + @"- to add vertical tab \v ");

    strEscape = "Summer\b2022";
    Console.WriteLine(strEscape + @"- to add backspace \b ");

    strEscape = "Summer\r2022";
    Console.WriteLine(strEscape + @"- to add carriage return \r ");

    strEscape = "Summer\02022";
    Console.WriteLine(strEscape + @"- to add null character \0 ");

    string strCmd = "c:\\Windows\\System32\\cmd.exe"; 
    string strCmd1 = @"c:\Windows\System32\cmd.exe"; // ignoring escape characters with an @ symbol  

    Console.WriteLine(strCmd + "");
    Console.WriteLine(strCmd1 + " - ignoring escape characters with an @ symbol");

    Console.WriteLine("--- String Compare ---");
    string auto = "Honda";
    bool a = (auto == "Honda"); //true

    Console.WriteLine(a + " - the way to compare two strings is simply by using the equal to operator (==)");

    Console.WriteLine("--- String Members ---");
    string strMem = "Everest";
    Console.WriteLine(strMem + " - original string");

    string strMem1 = strMem.Replace("v", "m"); // Emerest
    Console.WriteLine(strMem1 + " - method Replace");

    strMem1 = strMem.Insert(7, " - is is Earth's highest mountain"); // Everest - is Earth's highest mountain 
    Console.WriteLine(strMem1 + " - method Insert");

    strMem1 = strMem.Remove(0, 3); // rest
    Console.WriteLine(strMem1 + " - method Remove");

    strMem1 = strMem.Substring(0, 3); // Ever
    Console.WriteLine(strMem1 + " - method Substring");

    strMem1 = strMem.ToUpper(); // EVEREST
    Console.WriteLine(strMem1 + " - method ToUpper()");

    int strMem2 = strMem.Length; // 7
    Console.WriteLine(strMem2 + " - method Length");

    Console.WriteLine("--- StringBuilder Class ---");

    System.Text.StringBuilder sbc = new
    System.Text.StringBuilder("Air");
    Console.WriteLine(sbc + " - original string");

    sbc.Append("plane"); // Airplane
    Console.WriteLine(sbc + " - method Append");

    sbc.Remove(0, 3); // plane
    Console.WriteLine(sbc + " - method Remove");

    sbc.Insert(0, "Travel by "); // Travel by plane
    Console.WriteLine(sbc + " - method Insert");

    string justStr = sbc.ToString(); // Travel by plane
    Console.WriteLine(justStr + " - convert a StringBuilder object back into a regular string");

    }

}
