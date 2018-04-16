using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            double InputValue;
            Console.WriteLine("Температра в градусах по Цельсию");

            UserInput = Console.ReadLine();
            InputValue = double.Parse(UserInput);
            double ComputedValue = InputValue * 1.8 + 32;
            Console.WriteLine("C" + InputValue);
            Console.WriteLine("F" + ComputedValue);
            Console.WriteLine();
        }
    }
}
