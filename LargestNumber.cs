using System;
namespace Interview_Program
{
    public class LargestNumber
    {
       public static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter first numbers");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second numbers");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third numbers");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                    Console.WriteLine("a" + a + "is largest number");
                else
                    Console.WriteLine("c" + c + "is largest number");
            }
            else if (b > c)
            {
                Console.WriteLine("b" + b + "is largest number");
            }
            else
               Console.WriteLine("c" + c + "is largest number");
        }
    }
}
