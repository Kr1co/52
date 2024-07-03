using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    public class Group // Создаёт класс "Группа" для колледжей
    {
        public string Name { get; set; } // Объявляет переменную Name которой можно задавать значение типа string
        public string College { get; set; } // Объявляет переменную College которой можно задавать значение типа string

        public List<Students> Exp_Looter = new List<Students>(); // Создает коллекцию Студентов с названием Exp_Looter

        public Group(string name, string college)  // Задает порядок и тип переменных
        {
            Name = name; // Присваивает Name переменную name
            College = college; // Присваивает College переменную college
        }
        public void ShowAll() // Вроде бы выводит переменные 
        {
            Console.WriteLine($"Информация по группам:\n" +
                $"Название колледжа: {Name}\n" +  //Выводит на экран названия  Колледжей
                $"Название группы: {College}\n"); //Выводит на экран название группы  Колледжей
            Exp_Looter.Sort(); 
            foreach (Students p in Exp_Looter) // отображает студентов в Exp_Looter 
            {
                p.Show();
            }
        }
    }
}
