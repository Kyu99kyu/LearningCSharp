using System;

namespace MethodsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CallingMethod();
            
            Console.WriteLine(SumNumber(1,1));

            int res = SumNumber2(5, 5);

            Console.WriteLine(res);
        }

        //Doesn't return any value
        static void CallingMethod()
        {
            Console.WriteLine("hello I´m the method");
        }

        //return an int value
        static int SumNumber(int num1, int num2) { return num1 + num2; }
        //Same method with diferent Sintaxis
        static int SumNumber2(int num1, int num2) => num1 + num2; 

    }
}
