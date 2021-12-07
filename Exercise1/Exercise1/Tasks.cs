using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace Exercise1
{
    public class Tasks
    {
        public void Pow()
        {
            Console.WriteLine("Number?");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power?");
            int pow = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 0; i < pow; i++)
            {
                result *= number;
            }

            Console.WriteLine(result);
        }

        public void Task2()
        {
            Console.WriteLine("Number?");
            string key = Console.ReadLine();
            int counter = 0;
            int currentCounter = 0;
            char currentChar;
            char maxChar = default;
            for (int i = 0; i < key.Length; i++)
            {
                currentChar = key[i];
                for (int j = 0; j < key.Length; j++)
                {
                    if (currentChar == key[j])
                        currentCounter++;
                }

                if (currentCounter > counter)
                {
                    maxChar = currentChar;
                    counter = currentCounter;
                }

                currentCounter = 0;
            }

            Console.WriteLine(counter);
            Console.WriteLine($"max char {maxChar}");
        }

        public void Task3()
        {
            Console.WriteLine("Line pls");
            string line = Console.ReadLine();
            Console.WriteLine("What's the digit number you want?");
            int number = Convert.ToInt32(Console.ReadLine());
            List<int> digits = new List<int>();

            bool IsDigitPresent = false;
            char result = default;
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] > '0' && line[i] <= '9')
                {
                    IsDigitPresent = true;
                    counter++;
                }

                if (counter == number)
                    result = line[i];
            }

            if (counter == 0)
            {
                Console.WriteLine("Suck dick");
                return;
            }

            if (IsDigitPresent && counter == number)
            {
                Console.WriteLine($"Your number is {result}");
                return;
            }

            Console.WriteLine("Number is too BIG");
        }

        public void Task4()
        {
            var n = int.Parse(Console.ReadLine());
            int curentNumber;
            List<int> numbers = new List<int>();
            while (n != 0)
            {
                curentNumber = n % 10;
                n -= curentNumber;
                n /= 10;
                numbers.Add(curentNumber);
            }

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine("Number " + (numbers.Count - i) + $" is {numbers[i]} ");
            }
        }

        public void Task5()
        {
            Console.WriteLine("n?");
            var n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            var random = new Random();
            //  1 2 3
            //  4 5 6
            //  7 8 9
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = random.Next(20);
                    Console.Write($"{matrix[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Enter vector with {n} elements");
            List<int> vector = new List<int>();
            string user_data = Console.ReadLine();
            string[] numbers = user_data.Split(' ');
            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int tmp))
                    vector.Add(tmp);
            }

            if (vector.Count != n)
            {
                Console.WriteLine("Wrong vector");
                return;
            }

            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i] += matrix[i, j] * vector[j];
                }
            }

            Console.Write("Result vector = [");
            foreach (var x in result)
            {
                Console.Write($"{x} ");
            }

            Console.Write("]");
        }

        public void TaskArr()
        {
            Random random = new Random();
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = random.Next(-10, 10);
            }

            Console.WriteLine("=======");
            foreach (var x in arr)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("=======");

            TaskArr1(arr);
            TaskArr2(arr);
            TaskArr3(arr);
            TaskArr4(arr);
            TaskArr5(arr);
            TaskArr6(arr);
            TaskArr7(arr);
            TaskArr8(arr);
            TaskArr9(arr);
            TaskArr10(arr);
            TaskArr11(arr);
            TaskArr12(arr);
            TaskArr13(arr);
            TaskArr15(arr);
            TaskArr16(arr);
            TaskArr17(arr);
            TaskArr18(arr);
            TaskArr19(arr);
            TaskArr20(arr);
            TaskArr21(arr);
        }


        private void TaskArr1(int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                sum += n;
            }

            Console.WriteLine(sum);
        }

        private void TaskArr2(int[] arr)
        {
            int max = arr[0];
            foreach (var n in arr)
            {
                if (n > max)
                    max = n;
            }

            Console.WriteLine($"Max number: {max}");
        }

        private void TaskArr3(int[] arr)
        {
            int min = arr[0];
            foreach (var n in arr)
            {
                if (n < min)
                    min = n;
            }

            Console.WriteLine($"Min mumber: {min}");
        }

        private void TaskArr4(int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                if (n < 0)
                    sum += n;
            }

            Console.WriteLine(sum);
        }

        private void TaskArr5(int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                if (n > 0)
                    sum += n;
            }

            Console.WriteLine(sum);
        }

        private void TaskArr6(int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                if (n % 5 == 0)
                    sum += n;
            }

            Console.WriteLine(sum);
        }

        private void TaskArr7(int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                if (n < 0 && n % 2 != 0)
                    sum += n;
            }

            Console.WriteLine(sum);
        }

        private void TaskArr8(int[] arr)
        {
            int sum = 0;
            foreach (var n in arr)
            {
                sum += n;
            }

            Console.WriteLine(sum * 2);
        }

        private void TaskArr9(int[] arr)
        {
            int product = 1;
            int negProduct = 1;
            foreach (var n in arr)
            {
                if (n < 0)
                    negProduct *= n;
                if (n > 0)
                    product *= n;
            }

            Console.WriteLine($"Product of positive numbers: {product} \n" +
                              $"Product of negative numbers: {negProduct}");
        }

        private void TaskArr10(int[] arr)
        {
            int counter = 0;
            int negCounet = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    counter++;
                }
                else
                {
                    negCounet++;
                }
            }

            Console.WriteLine($"Count of positive numbers: {counter} \n " +
                              $"Count of negative numbers: {negCounet}");
        }

        private void TaskArr11(int[] arr)
        {
            int even = 0;
            int odd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine($"Count of even numbers: {even} \n " +
                              $"Count of odd numbers: {odd}");
        }

        private void TaskArr12(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    counter++;
            }

            Console.WriteLine($"Count of zeroes numbers: {counter} ");
        }

        private void TaskArr13(int[] arr)
        {
            Console.Write("Every second number of array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    Console.Write(arr[i] + ",");
            }

            Console.WriteLine();
        }

        private void TaskArr15(int[] arr)
        {
            Console.Write("Paired numbers :");
            foreach (var n in arr)
            {
                if (n % 2 == 0)
                    Console.Write(n + ",");
            }

            Console.WriteLine();
        }

        private void TaskArr16(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            foreach (var n in arr)
            {
                if (n < min)
                    min = n;
                if (n > max)
                    max = n;
            }

            Console.WriteLine($"Sum of min and max numbers{min + max}");
        }

        private void TaskArr17(int[] arr)
        {
            int sumPos = 0;
            int sumNeg = 0;
            foreach (var n in arr)
            {
                if (n > 0)
                {
                    sumPos += n;
                }
                else
                {
                    sumNeg += n;
                }
            }

            Console.WriteLine($"Difference in sum positive and negative numbers: {sumPos - sumNeg}");
        }

        private void TaskArr18(int[] arr)
        {
            int[] arrTmp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrTmp[i] = arr[i];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arrTmp[i] <= 0)
                {
                    arrTmp[i] = 0;
                }
                else
                {
                    arrTmp[i] = 1;
                }

                if (i != arr.Length - 1)
                {
                    Console.Write($"{arrTmp[i]}, ");
                }
                else
                {
                    Console.Write($"{arrTmp[i]}");
                }
            }
        }

        private void TaskArr19(int[] arr)
        {
            int[] arrTmp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrTmp[i] = arr[i];
            }

            Console.WriteLine();
            int counter = 0;
            for (int i = 0; i < arrTmp.Length; i++)
            {
                if (arrTmp[i] > 7)
                {
                    arrTmp[i] = 7;
                    counter++;
                }

                if (i != arr.Length - 1)
                {
                    Console.Write($"{arrTmp[i]}, ");
                }
                else
                {
                    Console.Write($"{arrTmp[i]}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Numbers > 7 count:" + counter);
        }

        private void TaskArr20(int[] arr)
        {
            int counter = 0;
            int maxAmount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                counter = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        counter++;
                }
                if (counter > maxAmount)
                    maxAmount = counter;
            }

            Console.WriteLine($"Max Amount {maxAmount}");
        }

        private void TaskArr21(int[] arr)
        {
            int counter = 0;
            bool isRepeated = false;

            for (int i = 0; i < arr.Length; i++)
            {
                isRepeated = false;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] == arr[j])
                    {
                        isRepeated = true;
                        break;
                    }
                }
                if (!isRepeated)
                    counter++;

            }

            Console.WriteLine(counter);
        }
        
    }
}