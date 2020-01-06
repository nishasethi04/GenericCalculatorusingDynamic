using System;

namespace GenericMethodPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            double a = 3.5;
           double b = 1.5;
            int z=Add<int>(x, y);
            int u = Sub<int>(x, y);
            int q = Mul<int>(x, y);
            double r = Add<double>(a, b);
            double s = Sub<double>(a, b);
            double e = Mul<double>(a, b);
            double i = Div<double>(a, b);
           
           
           Console.WriteLine(" Value of addition={0}",z);
            Console.WriteLine(" Value of subtraction={0}", u);
            Console.WriteLine(" Value of Multiplication={0}", q);
            Console.WriteLine(" Value of addition={0}", r);
            Console.WriteLine(" Value of subtraction={0}", s);
            Console.WriteLine(" Value of Multiplication={0}", e);
            Console.WriteLine(" Value of division={0}", i);
            x = 15;
            y = 0;
            int w = Div<int>(x, y);
            Console.WriteLine(" Value of division={0}", w);
            
         
        }







        public static T Add<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a + b;


        }
       

        public static T Sub<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a- b;
        }
        public static T Mul<T>(T x, T y)
        {
            dynamic a = x;
            dynamic b = y;
            return a * b;
        }
        public static T Div<T>(T x, T y)
        {
            try
            {
                dynamic a = x;
                dynamic b = y;
                return a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception raised");
                return default;
            }
            
        }
       
    }
}
