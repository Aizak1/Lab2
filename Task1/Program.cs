using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Entering the initial data
            Console.Write("Enter the number -> ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter The Degree -> ");
            int degree = int.Parse(Console.ReadLine());
            #endregion

            RootCalculator rootCalculator = new RootCalculator(number,degree);

            #region OutPut Roots calculated with two ways and their difference
            Console.WriteLine($"Your Result is : {rootCalculator.NewtonRoot}");
            Console.WriteLine($"Result by Math Pow {rootCalculator.PowRoot}");
            Console.WriteLine($"The difference is aroud : {rootCalculator.DifferenceBetweenTwoRoots.ToString("F7")}");
            #endregion

        }
    }
}
