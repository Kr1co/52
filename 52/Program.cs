using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("1-МОК", "22-25");// Создает новую группу колледж 1-МОК
            group.Exp_Looter.Add(new Students("Бабенко Егор Константинович", 4)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Бережко Денис Витальевич", 5)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Думнова Анна Валерьивна", 4)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Дьячков Иван Алексеевич", 2)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Буланов Виталий Андреевич", 4)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Алимова Анна Григорьевна", 3)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Кличко Денис Вячеславович", 5)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Свинизаврио Дмитрий Егорович", 5)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Собакин Максим Иванович", 4)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Собчак Валерия Денисовна", 2)); // Добавляет нового студента ФИО и средний балл
            group.Exp_Looter.Add(new Students("Цезарь Анна Вячеславовна", 3)); // Добавляет нового студента ФИО и средний балл
            group.ShowAll(); // Выводит на экран
            Console.ReadLine(); // Замораживает консольную строку
        }
    }
}
