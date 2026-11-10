using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticum.Menu
    {
    public class MenuRunner
        {
        public void Run()
            {
            Console.WriteLine("Практикум по C#");
            Console.WriteLine("1. Уровень 1");
            Console.WriteLine("2. Уровень 2");
            Console.WriteLine("3. Уровень 3");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите уровень: ");
            Console.ReadLine();
            }
        }
    }