using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uc2
{
    class Program
    {
        static void checkAttendance(int emp)
        {
            if (emp == 1)
            {
                Console.WriteLine("employee is here");
            }
            else
            {
                Console.WriteLine("employee absent");
            }
        }
        static void checkemployee(int a)
        {
            int workhours = 0;

            switch (a)
            {
                case 1:
                    {
                        workhours = 4;
                        Console.Write("part time employee so the wage is ");
                        break;
                    }
                case 2:
                    {
                        workhours = 8;
                        Console.Write("full time employee so the wage is ");
                        break;
                    }
                case 0:
                    {
                        workhours = 0;
                        Console.Write("not working so the wage is ");
                        break;
                    }
            }
            int wage = workhours * 20;
            Console.WriteLine(wage);

        }


        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            checkAttendance(value);
            checkemployee(value);

            int wph = 20; // work per hour 
            int hpd = 8; // hours in a day 
            int wpd = wph * hpd; // daily wage

            Console.Write("the daily wage is ");
            Console.WriteLine(wpd);
            Console.ReadLine();
        }
    }
}
