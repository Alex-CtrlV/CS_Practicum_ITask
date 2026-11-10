using CS_Practicum.Common;
using System;

namespace CS_Practicum.Tasks.Level1
    {
    public class Task01_HelloWorld : ITask
        {
        public string Title => "Task01_HelloWorld";
        public string Description => "Вывести две строки: приветствие и дату";
        public string[] Requirements => new[]
            {
            "Использовать Console.WriteLine",
            "Дату получить через DateTime.Now, отформатировать как dd.MM.yyyy"
            };

        public void Run()
            {
            Console.WriteLine($"Hello world and Timofey Sergeevych! Today {DateTime.Now.ToString("dd.MM.yyyy")}");
            }
        }
    }
