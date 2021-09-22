using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Kalkulaator_SergeiBubnovTARpe20
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstnum;
            double secondnum;
            double answer=0d;
            string ops;

            Console.WriteLine("\t\t\tConsole Calculator by Sergei Bubnov from TARpe20 in TTHK\n");
            Console.WriteLine("\t\t\t----------------------------------\r");


            Console.WriteLine("\t\t\tEnter the first number\n");
            firstnum = Double.Parse(Console.ReadLine());

            Console.WriteLine("\t\t\tSelect an operator: (+,-,/,*, **)\n");
            ops = Console.ReadLine();

            Console.WriteLine("\t\t\tEnter the second number\n");
            secondnum = Double.Parse(Console.ReadLine());
            if (ops=="+")
            {
                answer = firstnum + secondnum;
            }else if (ops == "-")
            {
                answer = firstnum - secondnum;
            }else if(ops == "/")
            {
                answer = firstnum / secondnum;
            }else if(ops == "*")
            {
                answer = firstnum * secondnum;
            }
            else if (ops=="**")
            {
                answer = Math.Pow(firstnum, secondnum);
            }
            Console.WriteLine(answer);
            Console.ReadKey();

        }
    }
}
