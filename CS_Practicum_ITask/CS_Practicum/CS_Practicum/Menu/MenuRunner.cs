using CS_Practicum.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Practicum.Menu;

namespace CS_Practicum.Menu
    {
    public class MenuRunner
        {
        public void Run()
            {
            var levelMenu = new LevelMenu();

            while (true)
                {
                Console.WriteLine("=== Практикум по C# ===");
                Console.WriteLine("1. Уровень 1 — Базовый (задания 1–15)");
                Console.WriteLine("2. Уровень 2 — Средний (задания 16–35)");
                Console.WriteLine("3. Уровень 3 — Продвинутый (задания 36–50)");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите уровень: ");

                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                    {
                    Console.WriteLine("Введите число.");
                    continue;
                    }

                switch (choice)
                    {
                    case 1:
                        levelMenu.Show();
                        break;
                    case 2:
                        Console.WriteLine("Уровень 2 пока не реализован.");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Уровень 3 пока не реализован.");
                        Console.ReadLine();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Неверный выбор.");
                        break;
                    }
                }
            }
        }
    }
    