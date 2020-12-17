using System;

namespace Task1
{
    class RootCalculator
    {
        public double NewtonRoot { get; private set; }
        public double PowRoot { get; private set; }
        public double DifferenceBetweenTwoRoots { get; private set; }

        public RootCalculator(int number,int degree)
        {
            NewtonRoot = CalculateNthRoot(number, degree);
            PowRoot = Math.Pow(number, (double)1/degree);
            DifferenceBetweenTwoRoots = FindDifferenceBetweenTwoWaysOfCalc(NewtonRoot, PowRoot);
        }

        public double CalculateNthRoot(int number,int degree)
        {
            int nearestNumberWithRoot = FindNearestIntegerRoot(number, degree);
            double dividedNumber = (double)number / Math.Exp(Math.Log(nearestNumberWithRoot) * (degree-1));
            double result = ((degree-1)*nearestNumberWithRoot + dividedNumber)/(double)degree;
            return result;
        }

        private double FindDifferenceBetweenTwoWaysOfCalc(double firstResult,double secondResult)
        {
         
            return Math.Abs(firstResult-secondResult);
        }

        private int FindNearestIntegerRoot(int number, int degree)
        {

            double nthroot = Math.Exp(Math.Log(number) / degree);
            return (int)Math.Round(nthroot);
        }
    }
}
