namespace Struct
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            ComplexNumber<int> num1 = new ComplexNumber<int>(10, 5);
            ComplexNumber<int> num4 = new ComplexNumber<int>(3, 2);
            Console.WriteLine(num1 + num4);
            Console.WriteLine(num1 - num4);
            num1.Print();
            Console.WriteLine("Hi! Works!");
            Console.ReadLine();
            }
        }
    }
