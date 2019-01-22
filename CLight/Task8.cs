using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLight
{
    class Task8
    {
        private static void Main(string[] args)
        {
            /*8. Поликлиника усложнённая 
             * При выводе выводятся часы и минуты. Например, вместо 150 минут, выводится “1 час 50 минут”. Позволительно выводит например “0 часов 10 минут”
             */
            int queueLength;
            int remainingMinutes;
            int personReceptionTime = 10;

            string greeting = "Добро пожаловать в поликлинику.";
            string task = "Чтобы узнать время до Вашего приёма введите количество людей перед Вами: ";
            string unswer = "До Вашего приёма осталось {0} часов {1} минут.";

            Console.WriteLine(greeting);
            Console.Write(task);

            queueLength = Convert.ToInt32(Console.ReadLine());
            remainingMinutes = queueLength * personReceptionTime;
            Console.WriteLine(String.Format(unswer, remainingMinutes / 60, remainingMinutes % 60));

        }
    }
}
