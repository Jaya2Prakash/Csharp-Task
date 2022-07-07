using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacci series without Recursion");
            Console.WriteLine("Enter Fibonacci number");
            int fib_num = Convert.ToInt32(Console.ReadLine());

            int f1 = -1, f2 = 1, f3 = 0;

            for(int i = 0; i < fib_num; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2= f3;
                Console.Write(f3 +" ");
            }

            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Fibonacci series with Recursion");
            int n1 = -1, n2 = 1, n3 = 0;

            Console.WriteLine("Enter Fibonacci number");
            int fib_num1 = Convert.ToInt32(Console.ReadLine());
            fib_recursion(fib_num1);

            
            void fib_recursion(int count)
            {

                if (count>0)
                {
                    n3 = n1 + n2;
                    n1 = n2;
                    n2 = n3;
                    Console.Write(n3+ " ");
                    count--;
                    fib_recursion(count);
                }

            }
            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Prime Number");

            Console.WriteLine("Enter Number");
            int prime_num = Convert.ToInt32(Console.ReadLine());
            int temp = 0;
            for(int i = 2; i < prime_num; i++)
            {
                if(prime_num%i==0)
                {
                    temp = 1;
                    break;
                }
            }
            if (temp == 1)
                Console.WriteLine("Not a Prime Number");
            else
                Console.WriteLine("It is Prime Number");




            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Palindrome Number");

            Console.WriteLine("Enter Number");
            int palindrome_num = Convert.ToInt32(Console.ReadLine());
            int temp1 = palindrome_num;

            int rev = 0, pal_num = 0;

            while(palindrome_num>0)
            {
                rev = palindrome_num % 10;
                palindrome_num = palindrome_num / 10;
                pal_num = (pal_num * 10) + rev;
            }

            Console.WriteLine("Palindrome Number is "+pal_num);

            if (temp1 == pal_num)
                Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not a palindrome number");





            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Sum of the Number");

            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
            int dummy = 0,sum=0;

            while (num > 0)
            {
                dummy = num % 10;
                num = num / 10;
                sum = sum + dummy;
            }

            Console.WriteLine("Sum of the number " + sum);



            Console.WriteLine("");
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine("Decimal to Binary");


            Console.WriteLine("Enter Decimal Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int rem = 0 ;
            int j = 1, bin = 0;

            while(num1>0)
            {
                rem = num1 % 2 ;
                num1 = num1 / 2;
                bin += rem * j;
                j *= 10;


            }
            Console.WriteLine("ans {0}",bin);

        }
        */



        static void Main(string[] args)
        {
                bool select = true;
                do {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1 = Fibonacci ");
                Console.WriteLine("2 = Fibonacci with recursion");
                Console.WriteLine("3 = Prime Number ");
                Console.WriteLine("4 = Palindrome ");
                Console.WriteLine("5 = Sum of Numbers ");
                Console.WriteLine("6 = Decimal to binary ");
                Console.WriteLine("0 = Exit ");
                Console.WriteLine();
                Console.WriteLine();



                Console.WriteLine("Enter Number");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Fib();
                        break;

                    case 2:
                        FibRecursion();
                        break;

                    case 3:
                        Prime();
                        break;

                    case 4:
                        Palin();
                        break;

                    case 5:
                        SUM();
                        break;

                    case 6:
                        decbin();
                        break;
                    case 0:
                        Console.WriteLine("Thank You");
                        break;
                    default:
                        Console.WriteLine("Invalid Number");
                        break;
                }
                if (choice == 0)
                    select = false;
            }while(select==true);


            void Fib() 
            {
                Console.WriteLine();
                Console.WriteLine("Fibonacci series without Recursion");
                Console.WriteLine();
                Console.WriteLine("Enter Fibonacci number");
                int fib_num = Convert.ToInt32(Console.ReadLine());

                int f1 = -1, f2 = 1, f3 = 0;

                for (int i = 0; i < fib_num; i++)
                {
                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;
                    Console.Write(f3 + " ");
                }
            }

            





            void FibRecursion()
            {
                Console.WriteLine();
                Console.WriteLine("Fibonacci series with Recursion");
                Console.WriteLine();
                int n1 = -1, n2 = 1, n3 = 0;

                Console.WriteLine("Enter Fibonacci number");
                int fib_num1 = Convert.ToInt32(Console.ReadLine());
                fib_recursion(fib_num1);


                void fib_recursion(int count)
                {

                    if (count > 0)
                    {
                        n3 = n1 + n2;
                        n1 = n2;
                        n2 = n3;
                        Console.Write(n3 + " ");
                        count--;
                        fib_recursion(count);
                    }

                }
            }
            
            




            void Prime()
            {
                Console.WriteLine();
                Console.WriteLine("Prime Number");
                Console.WriteLine();
                Console.WriteLine("Enter Number");
                int prime_num = Convert.ToInt32(Console.ReadLine());
                int temp = 0;
                for (int i = 2; i < prime_num; i++)
                {
                    if (prime_num % i == 0)
                    {
                        temp = 1;
                        break;
                    }
                }
                if (temp == 1)
                    Console.WriteLine("Not a Prime Number");
                else
                    Console.WriteLine("It is Prime Number");
            }
            
            



            void Palin()
            {
                Console.WriteLine();
                Console.WriteLine("Palindrome Number");
                Console.WriteLine();
                Console.WriteLine("Enter Number");
                int palindrome_num = Convert.ToInt32(Console.ReadLine());
                int temp1 = palindrome_num;

                int rev = 0, pal_num = 0;

                while (palindrome_num > 0)
                {
                    rev = palindrome_num % 10;
                    palindrome_num = palindrome_num / 10;
                    pal_num = (pal_num * 10) + rev;
                }


                if (temp1 == pal_num)
                    Console.WriteLine("Palindrome Number");
                else
                    Console.WriteLine("Not a palindrome number");
            }
            
            





            void SUM()
            {
                Console.WriteLine();
                Console.WriteLine("Sum of the Number");
                Console.WriteLine();
                Console.WriteLine("Enter Number");
                int num = Convert.ToInt32(Console.ReadLine());
                int dummy = 0, sum = 0;

                while (num > 0)
                {
                    dummy = num % 10;
                    num = num / 10;
                    sum = sum + dummy;
                }

                Console.WriteLine("Sum of the number " + sum);
            }
            



            void decbin()
            {
                Console.WriteLine();
                Console.WriteLine("Decimal to Binary");
                Console.WriteLine();

                Console.WriteLine("Enter Decimal Number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                int rem = 0;
                int j = 1, bin = 0;

                while (num1 > 0)
                {
                    rem = num1 % 2;
                    num1 = num1 / 2;
                    bin += rem * j;
                    j *= 10;


                }
                Console.WriteLine("Binary Number is : {0}", bin);
            }
            

        }

    }
}
