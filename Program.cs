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
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int value = random.Next(0, 2);
            checkAttendance(value);
        }

            int wph = 20; // work per hour 
            int hpd = 8;// hours in a day 
            int wpd = wph * hpd;// daily wage
            Console.Write("the daily wage is ");
            Console.WriteLine(wpd);
            Console.ReadLine();
        }

    }
}
