using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLight
{
    class Task4
    {
        private static void Main(string[] args)
        {
            /*
             4. Приоритет  

                В данном коде допущена ошибка, в консоль выводится 165, хотя ожидается 21. Исправьте с помощью круглых скобок.  
 
                string message = "Результат: " + 8 * 2 + 5; 

                Console.WriteLine(message);   
             */
            string message = "Результат: " + (8 * 2 + 5);

            Console.WriteLine(message);
        }
    }
}
