using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    enum ProjectStatus
    {
        Проект,
        Исполенение,
        Закрыт
    }
    enum TaskStatus
    {
        Назначена,
        В_работе,
        На_проверке,
        Принята,
        Выполнена
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person teamlead = new Person("Александр", "тимлид");
            Person marketing1 = new Person("Тумаков", "рекламщик");
            Person marketing2 = new Person("Сергей", "рекламщик");
            Person tester = new Person("Николай", "тестер");
            Person engineer1 = new Person("Борис", "разработчик");
            Person engineer2 = new Person("Аркадий", "разработчик");
            Person engineer3 = new Person("Алексей", "разработчик");
            Person engineer4 = new Person("Юрий", "разработчик");
            Person accountant = new Person("Дмитрий", "бухгалтер");
            Person analyst = new Person("Евгений", "аналитик");
            Person designer = new Person("Иван", "дизайнер");

            Task TV_Marketing = new Task("Реклама на тв", "рекламщик");
            Task Billboard_Marketing = new Task("Реклама на биллбордах", "рекламщик");
            Task Website_Teset = new Task("Тест сайте", "тестер");
            Task Distribution_Of_Funds = new Task("Распределние средств", "бухгалтер");
            Task Data_Collection = new Task("Сборка данных", "аналитик");
            Task Appearance = new Task("Внешний вид", "дизайнер");
            Task Create_Website = new Task("Написание сайта", "разработчик");
            Task FunctionsAdd = new Task("Дрбавление функций", "разработчик");
            Task Visualize_Site = new Task("Визуализация сайта", "разработчик");
            Task Helping = new Task("Помощь другим разработчикам", "разработчик");





            List<Person> persons = new List<Person> { marketing1, marketing2, tester, engineer1, engineer2, engineer3, engineer4, accountant, analyst, designer };
            List<Task> tasks = new List<Task> { TV_Marketing, Billboard_Marketing, Website_Teset, Distribution_Of_Funds, Data_Collection, Appearance, Create_Website, FunctionsAdd, Visualize_Site, Helping };

            Project x = new Project("Создание сайта", DateTime.Today, "Валя", teamlead, tasks);
            x.Start(persons);

        }
    }
}
