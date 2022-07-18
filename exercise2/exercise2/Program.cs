using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string name = Console.ReadLine();


            Console.WriteLine("Substring");
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < name.Length - i; j++)
                {
                    
                    Console.WriteLine(name.Substring(i, j + 1));
                }
            }
            Console.WriteLine("Reeverse a string using for loop");
            for (int i = name.Length - 1; i >= 0; i--)
            {
                Console.Write(name[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Reverse a sting using foreach loop");
            string reverse = "";
            foreach (char c1 in name)
            {
                
                reverse = c1 + reverse;
                       
            }

            Console.WriteLine($"The Reverse string is : {reverse}");


            Console.WriteLine("count number of character occurences");
            char[] ch = name.ToCharArray();
            char c;
            for (int i = 0; i < name.Length; i++)
            {
                c = ch[i];
                int count = 1;
                for (int j = i + 1; j < name.Length; j++)
                {
                    if (ch[i] != '0')
                    {
                        if (c == ch[j])
                        {
                            count++;
                            ch[j] = '0';
                        }
                    }


                }
                if (ch[i] != '0')
                {
                    Console.WriteLine(c + " " + count);
                }

            }

            Console.WriteLine("Anagrams");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            

            if ((str1.Length) == (str2.Length))
            {
                char[] ch1 = str1.ToLower().ToCharArray();
                char[] ch2 = str2.ToLower().ToCharArray();

                Array.Sort(ch1);
                Array.Sort(ch2);

                string val1 = new string(ch1);
                string val2 = new string(ch2);

                if (val1 == val2)
                {
                    Console.WriteLine("Both the strings are Anagrams");
                }
                else
                {
                    Console.WriteLine("Both the strings are not Anagrams..");
                }
            }
            else
                Console.WriteLine("Both the strings are not Anagrams.");
        }
    }
}
