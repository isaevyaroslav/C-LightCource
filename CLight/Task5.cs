using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLight
{
    class Task5
    {
        private static void Main(string[] args)
        {
            /*
             На экране в специальной зоне выводятся картинки, по 3 в ряд. 
             Всего у пользователя в альбоме 52 картинки. 
             Код должен вывести, сколько полностью заполненных рядов можно будет вывести, и сколько картинок будет сверх меры. 

             В качестве решения ожидаю объявленные переменные с необходимыми значениями и вывод необходимых данных основываясь на значениях переменных.   
             */

            int imagesCount = 52;
            int rowLenght = 3;

            int rowsRezultCount = imagesCount / rowLenght;
            int imagesOutRows = imagesCount % rowLenght;

            Console.WriteLine("Из " + imagesCount + " картинок можно вывести полных " + rowsRezultCount + " рядов по " + rowLenght + " картинки и останется " + imagesOutRows + " картинка.");
        }
    }
}
