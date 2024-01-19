using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void checkAttendance(int emp)
        {
            if (emp == 1)
            {
                Console.WriteLine("employee is here");
                Console.ReadLine();
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
    }
}
