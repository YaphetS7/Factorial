using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64._6
{
    class Program
    {
        static void Main()
        {
            string a;
            int i, x, s, j, num1, ost, itog, c;
            s = 1;
            Console.WriteLine("Введите число");
            x = Convert.ToInt32(Console.ReadLine());
            int[] stroka = new int[10000000];
            a = "";
            a = x.ToString(a);
            ost = 0;
            if (x != 0)
               for (i = 1; i <= x - 1; i++)
               {
                  for (s = 1; s <= a.Length; s++)
                      stroka[s] = a[s - 1] - '0';
                  c = a.Length;
                  a = "";
                  for (j = c; j >= 0; j--) //calc result
                  {
                    num1 = stroka[j];
                    itog = num1 * i + ost;
                    ost = itog / 10;
                    if (j != 0)
                        a = (itog % 10) + a;  //add result to string format
                    if (j == 0)
                        a = itog + a;
                  }
                    ost = 0;
               }
            Console.WriteLine("Факториал числа равен");
            if (x == 0)
                Console.WriteLine(1);
            else
            {
                i = 0;
                while (a[i] == '0')
                    i++;
                for (; i < a.Length; i++) // print the result
                    Console.Write(a[i]);
            }
            Console.ReadLine();

        }
    }
}
