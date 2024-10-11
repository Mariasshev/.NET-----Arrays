using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpApplication.methodsOfArray
{
    class MainClass
    {
        static void Main()
        {
            #region 1 task
            //int[] array = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
            //int evenCount = 0;
            //int oddCount = 0;
            //int uniqueCount = 0;
            //int count = 0;

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] % 2 == 0) { evenCount++; }
            //    else if (array[i] % 2 != 0) { oddCount++; }

            //    for(int k = 0; k < array.Length; k++)
            //    {
            //        if (array[i] == array[k])
            //        {
            //            count++;
            //        }

            //    }
            //    if (count == 1)
            //    {
            //        uniqueCount++;
            //        count = 0;
            //    }
            //}

            //Console.WriteLine($"Количество чётных элементов: {evenCount}");
            //Console.WriteLine($"Количество нечётных элементов: {oddCount}");
            //Console.WriteLine($"Количество уникальных элементов: {uniqueCount}");

            #endregion

            #region 2 task
            //int[] array = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };

            //int number = int.Parse(Console.ReadLine());
            //if(number < array.Length + 1 && number > 0)
            //{
            //    for (int i = 0; i < number; i++)
            //    {
            //        Console.WriteLine(array[i]);
            //    }
            //}
            //else { Console.WriteLine("Wrong number!"); }

            #endregion

            #region 3 task
            //int[] array = { 1, 2, 3, 4, 5, 2, 3, 4, 8, 9, 10 };

            //Console.WriteLine("Enter number 1: ");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 2: ");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter number 3: ");
            //int n3 = int.Parse(Console.ReadLine());

            //int count = 0;
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] == n1)
            //    {
            //        if (array[i + 1] == n2)
            //        {
            //            if (array[i + 2] == n3)
            //            {
            //                count++;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine($"Количество повторов: {count}");

            #endregion

            #region 4 task
            int[] arr1 = { 1, 2, 3, 4, 5, 2, 3, 4, 8, 9, 10 };
            int[] arr2 = { 0, 2, 11, 3, 9, 32, 35, 0, 76 };
            

            Console.WriteLine("Array 3: ");


            List<int> arr3 = new List<int>();

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int k = 0; k < arr2.Length; k++)
                {
                    if (arr1[i] == arr2[k])
                    {
                        arr3.Add(arr1[i]);
                        break; 
                    }
                }
            }

            foreach (int item in arr3)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}

