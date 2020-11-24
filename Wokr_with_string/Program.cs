using System;
using System.Text;

namespace Wokr_with_string
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int k = 0;// код символа в соответствии с ASCII
            int i = 0;

            Console.WriteLine("");// ввод строки
            string S=Console.ReadLine();

            int[] A = new int[28];// массив для подсчета частот

            foreach(char c in S)// разделение строки на символы
            {
                k = Convert.ToInt32(c) - 97;// получение кода
                A[k]++;// подсчет количества кода
            }
                // перевести из кода в сиьвол пример aabbcc


            for (i = 0; i < 28; i++)
                Console.WriteLine($"{A[i]}");










        }
    }
}
