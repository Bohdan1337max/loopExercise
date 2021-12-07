using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Exercise1
{
    public class SpecialTask
    {
        private const char Division = '/';
        private const char Multiplication = '*';
        private const char _add = '+';
        private const char Subtraction = '-';

        // Подаём пример с умножением,дилением,сложением,вычитанием.
        // На выходе получаем результат примера.
        // находим умножение,деление
        // сначала найти число знаков * и / потом прокрутить цыкл?

        public string GetMathExample()
        {
            Console.WriteLine("Write Math Example");
            var example = Console.ReadLine();
            return example;
        }

        private void GetOperatedNumbers(StringBuilder endExample ,int index)
        {
            
            
        }
        private void Div(StringBuilder endExample)
        {
            for (var i = 0; i < endExample.Length; i++)
            {
                if (endExample[i] != Division) continue;
                var firstNumber = GetFirstNumber(endExample, i);
                var secondNumber = GetSecondNumber(endExample, i);
                var numberCount1 = firstNumber.Count();
                var numberCount2 = secondNumber.Count();
                var divResult = firstNumber / secondNumber;
                    
                endExample.Remove(i - numberCount1,numberCount2 + numberCount1 + 1);
                endExample.Insert(i - numberCount1, divResult);
            }
        }

        private void Add(StringBuilder endExample)
        {
            for (var i = 0; i < endExample.Length; i++)
            {
                if (endExample[i] != _add) continue;
                var firstNumber = GetFirstNumber(endExample, i);
                var secondNumber = GetSecondNumber(endExample, i);
                var numberCount1 = firstNumber.Count();
                var numberCount2 = secondNumber.Count();
                var addResult = firstNumber + secondNumber;
                    
                endExample.Remove(i - numberCount1,numberCount2 + numberCount1 + 1);
                endExample.Insert(i - numberCount1, addResult);
            }
        }

        private void Sub(StringBuilder endExample)
        {
            for (var i = 0; i < endExample.Length; i++)
            {
                if (endExample[i] != Subtraction) continue;
                var firstNumber = GetFirstNumber(endExample, i);
                var secondNumber = GetSecondNumber(endExample, i);
                var numberCount1 = firstNumber.Count();
                var numberCount2 = secondNumber.Count();
                var subResult = firstNumber - secondNumber;
                    
                endExample.Remove(i - numberCount1,numberCount2 + numberCount1 + 1);
                endExample.Insert(i - numberCount1, subResult);
            }
        }

        private void Mul(StringBuilder endExample)
        {
            for (var i = 0; i < endExample.Length; i++)
            {
                if (endExample[i] != Multiplication) continue;
                var firstNumber = GetFirstNumber(endExample, i);
                var secondNumber = GetSecondNumber(endExample, i);
                var numberCount1 = firstNumber.Count();
                var numberCount2 = secondNumber.Count();
                var mulResult = firstNumber * secondNumber;
                    
                endExample.Remove(i - numberCount1,numberCount2 + numberCount1 + 1);
                endExample.Insert(i - numberCount1, mulResult);
            }
        }

        private static int GetFirstNumber(StringBuilder endExample,int index)
        {
            var number = new StringBuilder();
            for (var i = index - 1; i <= endExample.Length - (endExample.Length - index); i--)
            {
                if (i < 0)
                {
                    break;
                }
                if (char.IsNumber(endExample[i]))
                    number.Append(endExample[i]);
                else
                    break;
            }
            string endNumber = number.ToString().Reverse();
            return Convert.ToInt32(endNumber);
        }

        private static int GetSecondNumber(StringBuilder endExample, int index)
        {
            var number = new StringBuilder();
            for (int i = index + 1; i < endExample.Length; i++)
            {
                if (char.IsNumber(endExample[i]))
                    number.Append(endExample[i]);
                else
                    break;
            }
            return Convert.ToInt32(number.ToString());
        }
            public void FindSign(string example)
        {
            var endExample = new StringBuilder(example);
            for (int i = 0; i < endExample.Length; i++)
            {
                if (endExample[i] == Division)
                {
                    Div(endExample);
                    i = 0;
                }

                if (endExample[i] != Multiplication) continue;
                Mul(endExample);
                i = 0;
            }
            for (int i = 0; i < endExample.Length; i++)
            {
                if (endExample[i] == _add)
                {
                    Add(endExample);
                    i = 0;
                }

                if (endExample[i] != Subtraction) continue;
                Sub(endExample);
                i = 0;
            }
            Console.WriteLine(endExample);
        }
    }
}