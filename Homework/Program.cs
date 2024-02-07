using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Conditional Statement hw1

            //Console.WriteLine("Enter the temperature:");
            //int temperature = Convert.ToInt32(Console.ReadLine());
            //if (temperature < 0)
            //{
            //    Console.WriteLine("Freezing weather");
            //}
            //else
            //{
            //    Console.WriteLine("Hot weather");
            //}

            ////Conditional Statement hw2

            //Console.WriteLine("Enter your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if (age < 13)
            //{
            //    Console.WriteLine("You are " + age + " years old. You are a Child");
            //}
            //else if (age >= 13 && age <= 19)
            //{
            //    Console.WriteLine("You are " + age + " years old. You are a Teenager");
            //}
            //else
            //{
            //    Console.WriteLine("You are " + age + " years old. You are an Adult");
            //}


            ////Conditional Statement Hw3

            //Console.WriteLine("Enter the temperature:");
            //int temperature = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("1.From C to F.");
            //Console.WriteLine("2.From F to C");
            //Console.WriteLine("choose 1 or 2");
            //int convert = Convert.ToInt32(Console.ReadLine());
            //if (convert == 1)
            //{
            //    temperature = (temperature * 9 / 5) + 32;
            //    Console.Write("Temperature from C to F is " + temperature );
            //}
            //else
            //{
            //    temperature = (temperature - 32) * 5 / 9;
            //    Console.Write("Temperature from F to C is " + temperature);
            // }


            ////Array Manipulations Hw1

            //int[] arr = { 1, 5, 7, -10, 4 };
            //int max = arr[0];
            //int min = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if(arr[i]<min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine("The maximum is "+ max+ " and the minimum is "+ min);

            //////Array Manipulations Hw2
            //int[] arr = { 5, 10, 78, 4, 2 };
            //int i = 0;
            //int j = arr.Length - 1;
            //while (i < j)
            //{
            //    int temp = arr[i];
            //    arr[i] = arr[j];
            //    arr[j] = temp;
            //    i++;
            //    j--;
            // }
            // for(int k = 0; k < arr.Length; k++)
            //{
            //    Console.Write(arr[k] + ", ");
            //}

            ////Array Manipulations Hw3
            //int[] arr = { 2, 10, 25, 7,16, 1 };
            //int max = arr[0];
            //int secondMax = arr[0];

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > secondMax && arr[i]!=max)
            //    {
            //        secondMax = arr[i];
            //    }
            //}
            //Console.WriteLine(secondMax);

            ////Array Manipulations Hw3

            //int[] arr1 = { 1, 2, 3 };
            //int[] arr2 = { 4, 5, 6 };
            //int[] arr3 = new int[arr1.Length];

            //if (arr1.Length == arr2.Length)
            //{
                

            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        arr3[i] = arr1[i] + arr2[i];
            //        Console.WriteLine(arr3[i]);
            //    }


            //}
            //else
            //{
            //    Console.WriteLine("The lengths must be equal.");
            //}
            Console.ReadKey();
        }

    }






}
