using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите свою электронную почту:");  
            var str = Console.ReadLine();
            var index = str.IndexOf('@');
            var mailBox = str.Substring(0, index);
            var mailservice = str.Substring(index + 1);


            Console.WriteLine("Ваш почтовый ящик {0} находиться на сервисе {1}", mailBox, mailservice); 

        }

        }
    }

    