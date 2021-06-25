using System;
namespace Interview_Program
{
    public class PalindromeString
    {
       public static void Main()
        {
            Console.WriteLine("Enter the string");
            String msg = Console.ReadLine();
            string rev = string.Empty;

            foreach(char c in msg)
            {
                rev = c + rev;
            }
            if (msg == rev)
                Console.WriteLine("string is palindrome " + rev);
            else
                Console.WriteLine("string is not palindrome");
        }
    }
}
