using System;
using System.Collections.Generic;

namespace Interview_Program
{
    public class CharCount
    {
        public static void Main()
        {
            Console.WriteLine("Enter Message");
            string msg = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach(char ch in msg.Replace(" ", string.Empty)) {
                if(dict.ContainsKey(ch))
                {
                    dict[ch] = dict[ch] + 1;
                }
                else
                {
                    dict.Add(ch, 1);
                }
            }
            foreach (var item in dict.Keys)
            {
                Console.WriteLine(item + ":" + dict[item]);

            }
            Console.ReadKey();
        }
                
    }
    
}
