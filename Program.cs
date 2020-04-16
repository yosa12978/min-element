using System;

namespace vvodSearch
{
    class Program
    {
        public static void Printarray(int[] arr)
        {
            foreach(int i in arr)
                Console.Write($"{i} ");
            Console.WriteLine("\n");
        }
        public static int[] sort(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
                for(int j = 0; j < arr.Length-i-1; j++)
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите количество элементов в массиве: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write($"{i} элемент массива: ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Printarray(arr);
            int[] array = sort(arr);
            Printarray(array);
            Console.WriteLine("\nМинимальный элемент массива - " + array[0].ToString());
            Console.ReadKey();
        }
    }
}
