// See https://aka.ms/new-console-template for more information

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

//calculator
using System;

public class HelloWorld
{
    static int Sum(int a, int b)
    {
        return a + b;
    }
    static int Sub(int a, int b)
    {
        return a - b;

    }
    static float Divide(int a, int b)
    {
        return a / b;
    }
    static int MOD(int a, int b)
    {
        return a % b;
    }
    static int Multiplication(int a, int b)
    {
        return a * b;
    }
    static bool Prime(int num)
    {
        bool IsPrime = true;
        for (int i = 2; i < num / 2; i++)
        {
            if (num % i == 0)
            {
                IsPrime = false;
            }
        }
        return IsPrime;
    }
    static int Factorial(int num)
    {
        int counter = 1;
        int result = num;
        while (counter < num)
        {
            result *= counter;
            counter++;
        }
        return result;
    }
    static double sqRoot(int num)
    {
        double result = Math.Sqrt(num);
        return result;
    }

    static void Calculator()
    {
        int result=0;
        Console.WriteLine("Select Function: ");
        Console.WriteLine("Press: 1) add, 2) subtract, 3) Divide, 4) MOD, 5)Multiplication 6)PRime Number 7)FActorial 8)Square root ");
        int option = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Select operand1: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Select operand2: ");
        int b = Convert.ToInt32(Console.ReadLine());
        switch (Convert.ToInt32( option))
        {
            case 1:
               result= Sum(a, b);
                Console.WriteLine(result);

                break;
            case 2:
                result = Sub(a, b);
                Console.WriteLine(result);
                break;
            case 3:
                double ans = Divide(a, b);
                Console.WriteLine(result);
                break;
            case 4:
                result = MOD(a, b);
                Console.WriteLine(result);
                break;
            case 5:
                result = Multiplication(a, b);
                Console.WriteLine(result);
                break;
            case 6:
                bool check = Prime(a);
                if (check == true)
                    Console.WriteLine("true");
                else
                {
                    Console.WriteLine("false");
                }
                break;
            case 7:
                result = Factorial(a);
                Console.WriteLine(result);
                break;
            case 8:
                double sq = sqRoot(a);
                Console.WriteLine(sq);
                break;
            default:
                Console.WriteLine("no");
                break;

        }


    }

    static bool Palindrome(string str)
    {
        int len = str.Length;
        bool IS = true;
       
            for (int i = 0, j = len-1; i < len/2 ;i++, j--)
            {
                if (str[i] != str[j])
                {
                    IS = false;
                    break;
                }
            }

        return IS;
    }
    static string reverse(string str)
    {

        string[] result = str.Split(' ');
        string final="\0";
        for( int i = result.Length - 1; i>=0 ;i--) 
        {
            final += result[i]+ " ";
        }
        return final;
    }
    public static void Main()
    {
        Console.WriteLine("Hello Mono World");
        Calculator();
        Console.WriteLine("Enter palindrome");
        string pali = Console.ReadLine();
        bool palindrome = Palindrome(pali);
        Console.WriteLine(palindrome);
        Console.WriteLine("Enter sentence");
        string line = Console.ReadLine();
        string rev = reverse(line);
        Console.WriteLine(rev);
    }
}
