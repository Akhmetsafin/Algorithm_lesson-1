using System;

namespace Algoritms_1
{
    class Program
    {
        static long Reverse(long n) //В данном случае ввод — это просто
                                    //аргумент функции. Просто входной параметр.
        {
            long newN = 0;
            while (n > 0)
            {
                newN = newN * 10 + n % 10;
                n /= 10;
            }
            return newN;
        }
        static void Main(string[] args)// определяем введенное число является ли простым или не простымБ т.е.
                                       // при делении на 2 есть остаток
        {
            VerificationNum();
            //int n = 1234567891;
            //Console.WriteLine($"Output: {Reverse(n)}");
        }
        static void VerificationNum()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 2;
            int d = 0;

            while (i < number)// проверка условия
            {
                if (number%i == 0)
                {
                    
                    i++;
                    d++;
                }
                else
                {
                    i++;
                   
                }
            }
           
                if (d == 0)
                {
                    Console.WriteLine($"{number}: Простое число"); //ВЫВОД
                }
                else
                {
                    Console.WriteLine($"{number}: Не простое число"); //ВЫВОД
                }
            

           VerificationNum();
        }
        //static void efklid(int a, int b)
        //{
        //    {

        //        //НАЧАЛО БЛОКА ВВОДА
        //        Console.WriteLine("Input a:");
        //        a = int.Parse(Console.ReadLine()); // правильнее будет написать
        //                                           //                int.TryParse, так как это позволит избежать exception в случае, если в строке
        //                                           //будет не число.Для данного примера этим можно пренебречь.
        //                                           //Console.WriteLine("Input b:");
        //        b = int.Parse(Console.ReadLine());
        //        //КОНЕЦ БЛОКА ВВОДА
        //        while (a != b) //УСЛОВИЕ ЦИКЛА
        //        { //НАЧАЛО ТЕЛА ЦИКЛА
        //            if (a > b) //УСЛОВИЕ
        //            {
        //                a = a - b; //ДЕЙСТВИЕ, ЕСЛИ УСЛОВИЕ ВЫПОЛНИЛОСЬ
        //            }
        //            else
        //            {
        //                b = b - a; //ДЕЙСТВИЕ, ЕСЛИ УСЛОВИЕ НЕ ВЫПОЛНИЛОСЬ
        //            }
        //        } //КОНЕЦ ТЕЛА ЦИКЛА
        //        Console.WriteLine($"GDC: {a}"); //ВЫВОД
        //    }

        //}

    }
}
