using System;

namespace MyNamespace
{
    public class Exercise6
    {
        public static void Main(string[] args)
        {
            // typy casting

            double a = 3.14;
            int b = Convert.ToInt32(a);
            
            int c = 123;
            double d = Convert.ToDouble(c);

            int e = 321;
            String f = Convert.ToString(e);
                
            Console.WriteLine(b);
            Console.WriteLine(a.GetType());
            
            Console.WriteLine(d);
            Console.WriteLine(d.GetType());

            Console.WriteLine(f);
            Console.WriteLine(f.GetType());

            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);
            Console.WriteLine(h.GetType());
            
            String i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine(j);
            Console.WriteLine(j.GetType());

            Console.ReadKey();
            Console.Beep();
        }
    }
}