using System;
using System.Collections.Generic;


namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 55;
        int b = 65;
 
Console.WriteLine("earliest form");
Console.WriteLine("1st Variable: {0}",a);
Console.WriteLine("2nd Variable: {0}", b);

 
a = a + b;
b = a - b;
a = a - b;
Console.WriteLine("********");
Console.WriteLine("Now they became");
Console.WriteLine("Variable 1={0}",a);
Console.WriteLine("Variable 2={0}", b);

 
Console.ReadKey();
 
        }
    }
}
