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
            string[] sonad = new string[7] { "aaa","bbb","ccc","ggg","eee","zzz","lll"};//[7]-строк ограничения
            foreach (string sõna in sonad)
            {
                Console.WriteLine(sõna);
            }
            for (int i = 0; i < sonad.Length; i++) // i++=+1
            {
                Console.WriteLine(sonad[i]);
                
            }
            ConsoleKeyInfo key = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Vajuta Escape");
                key = Console.ReadKey();
            } while (key.Key!=ConsoleKey.Escape);


            
            
            
            Console.ReadLine(); //Не закрывает программу
        }
    }
}
