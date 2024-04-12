using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Омагад_омагад_4
{
    class Program
    {
        public static void UserNum1(out int n, out double x, out double s, out int d)
        {
            Console.Write("Необходимое количество значений:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nМинимальное значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nШаг x:");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nЗадержка каждого шага:");
            d = Convert.ToInt32(Console.ReadLine());
        }
        public static void UserNum2(out int n, out double x, out double s, out int d)
        {
            Console.Write("\nМинимальное значение x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nШаг x:");
            s = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nЗадержка каждого шага:");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВремя выполнения потока:");
            n = Convert.ToInt32(Console.ReadLine());
        }



        static void Main(string[] args)
        {
            int n1;
            double x1;
            double s1;
            int d1;
            int t;
            double x2;
            double s2;
            int d2;

            void schitalka()
            {
                while (true)
                {
                    Console.WriteLine($"{x2};{Math.Cos(x2)}");
                    x2 += s2;
                    Thread.Sleep(d2);
                }
            }

            UserNum1(out n1, out x1, out s1, out d1);
            UserNum2(out t, out x2, out s2, out d2);

            Thread t1 = new Thread(delegate ()
            {
                int n = 0;
                while (n < n1)
                {
                    Console.WriteLine($"{x1};{Math.Sin(x1)}");
                    x1 += s1;
                    n++;
                    Thread.Sleep(d1);
                }
            });

            //Thread t2 = new Thread(new ThreadStart(schitalka));

            Thread t2 = new Thread(delegate ()
            {
                DateTime starttime = DateTime.Now;
                DateTime current;
                int interval = 0;
                while (interval < t)
                {
                    
                    current = DateTime.Now;
                    interval = current.Second - starttime.Second;
                    Console.WriteLine($"{x2};{Math.Cos(x2)}");
                    x2 += s2;
                    Thread.Sleep(d2);
                }
            });
            t1.Start();
            t1.Join();
            t2.Start();
            t2.Join();
        }
    }
}
