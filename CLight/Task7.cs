using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLight
{
    class Task7
    {

        private static void Main(string[] args)
        {
            /*7. Поликлиника 

            Легенда: 
                Вы заходите в поликлинику и видите огромную очередь из старушек, вам нужно рассчитать время ожидания в очереди.  

            Формально: 
                Пользователь вводит кол-во людей в очереди.  
                Фиксированное время приема одного человека всегда равно 10 минутам.  
                Пример вывода: "Вы должны отстоять в очереди 150 минут."   
             */
            int queueLength;
            int personReceptionTime = 10;

            string greeting = "Добро пожаловать в поликлинику.";
            string task = "Чтобы узнать время до Вашего приёма введите количество людей перед Вами: ";
            string unswer = "До Вашего приёма осталось {0} минут.";

            Console.WriteLine(greeting);
            Console.Write(task);

            queueLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(String.Format(unswer, queueLength * personReceptionTime));

        }
    }
}
