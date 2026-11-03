using CS_Practicum.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practicum.Tasks.Level1
    {
    public class Task01_HelloWorld : ITask
        { 
        public string Title => "Hello World + Сегоднящняя дата";
        public string Description => "Вывести приветствие и текущую дату";
        public string[] Requirements => new[]
            {
            "Использовать Console.WriteLine",
            "Дату через DateTime.Now в формате dd.MM.yyyy"
            };

        public void Run()
            {
            Console.WriteLine($"Hello world & Timofey Sergeevych! Today:{DateTime.Now.ToString("dd.mm.yyyy")}");
            }
        }
    }
