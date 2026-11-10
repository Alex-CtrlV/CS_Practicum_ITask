using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practicum.Menu
    {
    public class LevelMenu
        {
        private readonly Dictionary<int, ITask> _tasks = new Dictionary<int, ITask>
        {
            { 1, new Task01_HelloWorld() },
            { 2, new Task02_Primitieves() },
        };


        public void Show()
            {
            while (true)
                {
                Console.WriteLine("=== Практикум по C# ===");
                Console.WriteLine("Уровень 1 - Базовый (задания 1-15)");

                foreach (var pair in _tasks.OrderBy(p => p.Key))
                    {
                    Console.WriteLine($"{pair.Key}. {pair.Value.Title}");
                    }
                Console.WriteLine("0. Назад");
                Console.Write("Выберите задание: ");
                string input = Console.ReadLine();
                int choice;
                if (!int.TryParse(input, out choice))
                    {
                    Console.WriteLine("Введите число.");
                    continue;
                    }

                if (choice == 0)
                    return;

                ITask selected;
                if (!_tasks.TryGetValue(choice, out selected))
                    {
                    Console.WriteLine("Нет такого задания.");
                    continue;
                    }

                RunTask(selected);
                }
            }

        private void RunTask(ITask task)
            {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine($"Задание. {task.Title}");
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("Описание:");
            Console.WriteLine($"  {task.Description}");
            Console.WriteLine();
            Console.WriteLine("Требования:");
            foreach (var req in task.Requirements)
                Console.WriteLine($"  - {req}");
            Console.WriteLine(new string('-', 50));

            task.Run();

            Console.WriteLine();
            Console.Write("Нажмите Enter для возврата в меню...");
            Console.ReadLine();
            }

        }
        }
        

