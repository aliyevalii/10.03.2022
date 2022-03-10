using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4 };
                      
            MinMaxMarge(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+",");
            }
        }
        static void MinMaxMarge(int[] numbers)
        {
            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 0; i <numbers.Length; i++)
            {
                if (numbers[minIndex] > numbers[i])
                {
                    minIndex = i;
                }
                if (numbers[maxIndex] < numbers[i]) 
                { 
                
                    maxIndex = i;
                }
                
            }
            numbers[maxIndex] = numbers[maxIndex] + numbers[minIndex];
            numbers[minIndex] = numbers[maxIndex] - numbers[minIndex];
            numbers[maxIndex] = numbers[maxIndex] - numbers[minIndex];


        }

    }
}
