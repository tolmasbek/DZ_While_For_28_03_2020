﻿using System;

namespace DZ_Cs_Cycles_28_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                • Задание 1
                    o Выучите основные конструкции и понятия, рассмотренные на уроке.
            */
                System.Console.WriteLine("/////////////////////////////////////////");
            /*
                • Задание 2
                    o Используя Visual Studio Code, создайте проект по шаблону Console Application.    
                        § Дано два числа A и B (A<B) выведите суму всех чисел, расположенных между
                        данными числами на экран.
                    
                        § Дано два числа A и B (A<B) выведите все нечетные значения, расположенные
                        между данными числами.
            */
                int A = 2, B = 7; 
                int s = 0;
                for(int i = A + 1; i < B; i++)
                {
                    s += i;
                    if(i % 2 != 0)
                    {
                        System.Console.WriteLine($"Nechetnie chisla mejdu {A} i {B} : {i}");
                    }
                }
                System.Console.WriteLine($"Summa chisel mejdu {A} i {B} = {s}");

            //////////////////////////////////////////////////////////////////////////////////
            /// Были сложности в определении чисел между А и В не включая А 
            /// сначала сделал А - 1 не получилось 
            /// долго думал и наконец подумал А + 1
            ///     
            //////////////////////////////////////////////////////////////////////////////////
            
            /*
                • Задание 3
                    o Используя Visual Studio Code, создайте проект по шаблону Console Application.
                    Используя циклы и метод:
                    Console.Write("*"), Console.Write(" "), Console.Write("\n") (для перехода на новую
                    строку).
                        Прямоугольник       Прямоугольник   Равносторонний          Ромб
                                            треугольник     треугольник

                        **************        *                     *                 *
                        *            *        * *                 *   *             *   *
                        *            *        *   *             *       *         *       *
                        *            *        *     *         *           *         *   *
                        **************        ********       ***************          *
            */
            // Прямоугольник
            System.Console.WriteLine("///PRYAMOUGOLNIK///");
            for(int i = 0; i <= 5; i++)
            {
                for(int j = 0; j <= 10; j++)
                {
                   System.Console.Write("*" + " ");
                }
                System.Console.WriteLine("*");
            }

            // Прямоугольный треугольник
            System.Console.WriteLine("///PRYAMOUGOLNIY TREUGOLNIK///");
            
            for(int i = 0; i <= 10; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    System.Console.Write("*" + " ");
                }
                System.Console.WriteLine(" ");
            }       
            
            // Равносторонний треугольник
            System.Console.WriteLine("///RAVNOBEDRENNIY TREUGOLNIK///");
            /// 
            for(int i = 0; i < 9; i++)
            {
                for(int j = 1; j < 9 - i; j++)
                    System.Console.Write(" ");
                for(int j = 9 - i; j < 9 + i; j++)
                    System.Console.Write("*");
                    System.Console.WriteLine("*");
            }

            /// Ромб
            System.Console.WriteLine("///ROMB///");

            /*
                • Задание 4
                    o Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада
                    увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P <
                    25). По данному P определить, через сколько месяцев размер вклада превысит 1100
                    руб., и вывести найденное количество месяцев K (целое число) и итоговый размер
                    вклада S (вещественное число).
            */
            ///
            /// P = 3,50
            /// K = 3     S = 1108,72   
            ///   
            /// 
            float P = 0;
            int K = 0;
            float S = 1000f;
            
percent:    System.Console.Write("Vvedite godovoy % (0 < P < 25), P = ");
            P = float.Parse(Console.ReadLine());
            if((P - 25) <= 0){
            while(S <= 1100)
            {
                S = S + ((S * P) / 100);
                K++;
            }
            System.Console.WriteLine($"Cherez {K} mesyacev razmer vklada previsit 1100 rub\ni itogoviy razmer vklada sostavit = {S}");
            }
            else{
                System.Console.WriteLine($"P ne doljen previshat 25 % !!!");
                goto percent;
            }

            /////////////////////////////////////////////////////////////////////////////////////
            /// Хотел сделать с for но не понял 
            /// for(int i = 0; i <= 1100; i++) так правильно ?
            /// 
            Console.ReadKey();
        }
    }
}