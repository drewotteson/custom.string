using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MutableString
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomizeString cs = new CustomizeString();
            //cs.ToUpper("whatever");
            //Console.WriteLine();

            //cs.ToLower("WHATEVER");
            //Console.WriteLine();

            //cs.Split("whatever");
            //Console.WriteLine();

            //Console.WriteLine(cs.Contains("you", "you"));
            Console.WriteLine(cs.Contains("whatever", "eh"));
            //cs.Count("whatever");
            //Console.WriteLine();

            //cs.Replace("whatever you want", "you", "she");

            Console.ReadLine();
        }
    }
}
