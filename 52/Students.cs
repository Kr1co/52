using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    public class Students : IComparable<Students> // Делает Класс студенты зависимым от IComparable и дает ему сортироваться
    {
        public string Name { get; set; } // Объявляет переменную Name которой можно задавать значение типа string
        public int Ocenka { get; set; } // Объявляет переменную Ocenka которой можно задавать значение типа int
        public Students (string name, int oc) // Задает порядок и тип переменных
        {
            Name = name; // Задает Name Значение name
            Ocenka = oc; // Задает Ocenka Значение oc
        }
        public void Show() //Выводит на экран текст ниже 
        {
            Console.WriteLine($"Имя студента: {Name}\n"+ //Выводит на экран Имена Студентов
            $"Оценка студента: {Ocenka}\n"); //Выводит на экран средние оценки Студентов
        }
        public int CompareTo(Students other)// Сортирует Студентов в колледже по алфовиту
        {
return Name.CompareTo( other.Name );
        }
    }
}
