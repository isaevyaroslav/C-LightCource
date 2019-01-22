using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLight
{
    class Task6
    {
        private static void Main(string[] args)
        {
            /*
                6. Магазин 
                    Легенда: 
                        Вы приходите в магазин и хотите купить за своё золото кристаллы. 
                        В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас, сколько кристаллов вы хотите купить? 
                        После сделки у вас остаётся какое-то количество золото и появляется какое-то количество кристаллов.  

                    Формально: 
                        При старте программы пользователь вводит начальное количество золота. 
                        Потом ему предлагается купить какое-то количество кристаллов по цене N. 
                        Пользователь вводит число и его золота конвертируется в кристаллы. Остаток золота и кристаллов выводится на экран. 

             */
            int goldCount;
            int cristalPrice = 2;
            int cristalCount;


            string greeting = "Добро пожаловать в магазин кристаллов. Стоимость одного кристалла " + cristalPrice + " золота.";
            string question = "Сколько золота Вы хотите потратить на покупку кристаллов?";
            string goldCountTip = "Введите количество золота: ";

            string unswer = "На это количество золота Вы купили {0} кристаллов и у Вас осталось {1} золота.";
            string goodbye = "Досвиданья. Приходите ещё.";

            Console.WriteLine(greeting);
            Console.WriteLine(question);
            Console.Write(goldCountTip);
            goldCount = Convert.ToInt32(Console.ReadLine());
            cristalCount = goldCount / cristalPrice;
            goldCount = goldCount - cristalPrice * cristalCount;
            Console.WriteLine(String.Format(unswer, cristalCount, goldCount));
            Console.WriteLine(goodbye);
        }
    }
       
}
