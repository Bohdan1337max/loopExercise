using System;

namespace Exercise1
{
    public class Algorithms
    {
        public int[] GenerateArr(int n)
        {
            Random random = new Random();
           
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(0, 10);
            }

            return arr;
        }
        
        public void PrintArr(int[] arr)
        {
            Console.WriteLine("=======");
            foreach (var x in arr)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("=======");
        }
        public void BubbleSort(int[] arr)
        {
            int tmp = 0;
            
            for (int i = 0; i < arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1]) 
                    {
                       tmp = arr[j];
                       arr[j] = arr[j + 1];
                       arr[j + 1] = tmp;
                    }
                    
                }
                
            }
        }
       
        static int BinarySearch(int[] array, int searchedValue, int left, int right)
        {
            
            while (left <= right)
            {
                
                var middle = (left + right) / 2;

                if (searchedValue == array[middle])
                {
                    return middle;
                }
                else if (searchedValue < array[middle])
                {
                    
                    right = middle - 1;
                }
                else
                {
                    
                    left = middle + 1;
                }
            }
           
            return -1;
        }
        public void SeletionSort(int[] arr)
        {
            int n = 10;
            int temp, min;
            for (int i = 0; i < n - 1; i++) 
            {
                min = i;
                for (int j = i + 1; j < n; j++) {
                    if (arr[j] < arr[min]) {
                        min = j;
                    }
                }
                temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }
        }
    }
}