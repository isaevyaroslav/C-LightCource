using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLight
{
    class Task3
    {
        static void Main(string[] args)
        {
            /*
             * 3. Что выведется в консоль?  ВАЖНО!!! Не запускать код и попытаться подумать головой 
             */
            int a = 10;
            int b = 38 * 17;
            int c = (31 - 5 * a) / b;
            Console.writeline(c);
            //Ошибка - у Console нет такого метода как writeline 
        }
    }
}
