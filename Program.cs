using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] mas = new int[];
            bool prost = true;
            Console.WriteLine("Enter the number");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    prost = false;
                    break;
                }
            }
            
        }
    }
}

//1

//int m;
//for (int i = 2; i < 10; i++)
//{
//    for (int j = 2; j < 10; j++)
//    {
//        m = i * j;
//        Console.WriteLine($"{i}  * {j}  =  {m}");
//    }
//    Console.WriteLine();
//}


//2

//ConsoleKeyInfo selection;
//selection = Console.ReadKey();
//Console.WriteLine();
//if (char.IsDigit(selection.KeyChar))
//{
//    Console.WriteLine("Yes");
//}
//else Console.WriteLine("No");


//3

//static void gish(ref double a, ref double b)
//{
//    a = a + b;
//    b = a - b;
//    a = a - b;
//}
//static void Main(string[] args)
//{
//    Console.WriteLine("Enter the number 1");
//    double a = double.Parse(Console.ReadLine());
//    Console.WriteLine("Enter the number 2");
//    double b = double.Parse(Console.ReadLine());

//    gish(ref a, ref b);

//    Console.WriteLine();
//    Console.WriteLine($"1= {a} 2= {b}");
//}

//4
//int[,] mas = new int[5, 5];
//Random randNum = new Random();
//Console.WriteLine("Enter Min");
//            int Min = int.Parse(Console.ReadLine());
//Console.WriteLine("Enter Max");
//            int Max = int.Parse(Console.ReadLine());

//            for (int i = 0; i< 5; i++)
//            {
//                for (int j = 0; j< 5; j++)
//                {
//                    mas[i, j] = randNum.Next(Min, Max);
//                }
//            }
//            for (int i = 0; i< 5; i++)
//            {
//                for (int j = 0; j< 5; j++)
//                {
//                    Console.Write(mas[i, j]);
//                }
//                Console.WriteLine();
//            }