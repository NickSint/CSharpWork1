using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();  //Очищяет текст и закрашивает вест фон
            Console.WriteLine("Hello world!"); //WriteLine приписка Line переносит на след. строчку курсор
            Random rnd = new Random(); //new Random создает метод рандома
            Console.WriteLine("jah-random number, ei-ise sisestan number");
            string soov = Console.ReadLine();  //Создает переменую которую вводит пользаватель, P.s input на Phyton
            int num = 0;
            if (soov == "jah") // если переменая равна "да" то...
            {
                num = rnd.Next(1, 7);    //создает переменую num,  rnd.Next вызывает функцию рандома
                

            }
            else
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (SystemException)
                {         
                }
                
            }

            Console.WriteLine("Päeva number: {0}", num.ToString()); //подставит число после (:), num.ToString переводит из int в string
            string nimetus = "";
            switch (num)
            {
                case 1: nimetus = "esmaspäev"; break; //case хранит данные
                case 2: nimetus = "teisipäev"; break;
                case 3: nimetus = "kolmapäev"; break;
                case 4: nimetus = "neljapäev"; break;
                case 5: nimetus = "reede"; break;
                case 6: nimetus = "laupäev"; break;
                case 7: nimetus = "pühapäev"; break;
                default: //похожая функция if на Phyton
                    nimetus = "Viga!";
                    break;
            }
           
            Console.WriteLine(nimetus); //ввыводит на экран переменую nimetus
            StreamWriter filesse = new StreamWriter(@"..\..\andmed.txt",true); //показывает что файл находится его путь, true добавляет новые файлы
            filesse.WriteLine("Number oli {0}, päev on {1}", num.ToString(), nimetus);
            filesse.Close();
            Console.WriteLine("Failis oli salveststud: Number oli " + num.ToString() + "päev on" + nimetus);
            StreamReader filest = new StreamReader(@"..\..\andmed.txt");
            string a = filest.ReadToEnd(); //читает файл от начала до конца
            Console.WriteLine("Failis oli seda: \n" + a); //  \n-новая строка
            
            
            
            
            Console.ReadLine(); //Не закрывает программу
        }
    }
}
