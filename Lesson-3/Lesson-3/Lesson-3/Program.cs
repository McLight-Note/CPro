using System;

namespace _3_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Max Value 16 bit: "  + short.MaxValue);
            Console.WriteLine("Min Value 16 bit: "  + short.MinValue);
            Console.WriteLine("Write a number: ");
            short _16_int = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");
            
            
            Console.WriteLine("Max Value of 32 bit: "  + int.MaxValue);
            Console.WriteLine("Min Value of 32 bit: "  + int.MinValue);
            Console.WriteLine("Write a number: ");
            int _32_int = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
            
            Console.WriteLine("Max Value 64 bit: "  + long.MaxValue);
            Console.WriteLine("Min Value 64 bit: "  + long.MinValue);
            Console.WriteLine("Write a number: ");
            long _64_int = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("");
            
            Console.WriteLine("Max Value double: "  + double.MaxValue);
            Console.WriteLine("Min Value double: "  + double.MinValue);
            Console.WriteLine("Write a number: ");
            double doubleNum = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");
            
            Console.WriteLine("Max Value decimal: "  + decimal.MaxValue);
            Console.WriteLine("Min Value decimal: "  + decimal.MinValue);
            Console.WriteLine("Write a number: ");
            decimal decimalNum = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");
            

            Console.WriteLine(_16_int);
            Console.WriteLine(_32_int);
            Console.WriteLine(_64_int);
            Console.WriteLine(doubleNum);
            Console.WriteLine(decimalNum);
        }
    }
};
