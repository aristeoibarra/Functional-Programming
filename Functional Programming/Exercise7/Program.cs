using System;

namespace Exercise7
{
    class Program
    {
        public delegate int DelegateCalculador(int v1, int v2);

        public static int Sum(int v1, int v2) => v1 + v2;
        public static int Subtract(int v1, int v2) => v1 - v2;
        public static int Multiply(int v1, int v2) => v1 * v2;
        public static int Divide(int v1, int v2) => v1 / v2;

        static void Main(string[] args)
        {
            /// Create a function called Calculator, which allows you to sum , subtract, multiply, and divide two whole numbers.
            /// The calculator function must be able to receive any type of operation (add, subtract, multiply and divide).

            DelegateCalculador sum = Sum;
            DelegateCalculador subtra = Subtract;
            DelegateCalculador mult = Multiply;
            DelegateCalculador divide = Divide;

            Console.WriteLine("Sum: " + Calculator(sum, 5,10));
            Console.WriteLine("Subtract: " + Calculator(subtra, 10,5));
            Console.WriteLine("Multiply: " + Calculator(mult, 2,5));
            Console.WriteLine("Divide: " + Calculator(divide, 6,3));
        }

        public static int Calculator(DelegateCalculador operacion, int v1, int v2) => operacion(v1, v2);
    }
}
