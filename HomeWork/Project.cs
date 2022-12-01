using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static HomeWork.Task;

namespace HomeWork
{
    internal class Project
    {
        public string description { get; set; }
        public DateTime deadline { get; set; }
        public string customer { get; set; }
        public Person teamlead { get; set; }
        public List<Task> tasks { get; set; }
        public ProjectStatus status { get; set; }

        public Project(string description, DateTime deadline, string customer, Person teamlead, List<Task> tasks)
        {
            this.description = description;
            this.deadline = deadline;
            this.customer = customer;
            this.teamlead = teamlead;
            this.status = ProjectStatus.Проект;
            this.tasks = tasks;
        }

        public List<Task> Move(List<Task> a)
        {
            Task b = a[a.Count - 1];
            for (int i = 0; i < a.Count - 1; i++)
            {
                a[i + 1] = a[i];
            }
            a[0] = b;
            return a;
        }

        public void Start(List<Person> persons)
        {
            status = ProjectStatus.Исполенение;
            Console.WriteLine($"{DateTime.Now}Исполнение проекта началось\n");
            while (tasks.Count > 0)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    for (int j= 0; j < persons.Count; j++)
                    {
                        tasks[i].customer = teamlead;
                        tasks[i].deadline = DateTime.Today;
                        tasks[i].executor = persons[j];
                        tasks[i].status = TaskStatus.На_проверке;
                        if (tasks[i].Test() == true)
                        {
                            tasks.RemoveAt(i);
                            persons.RemoveAt(j);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                    
                }
            }

            status = ProjectStatus.Закрыт;
            Console.WriteLine("Все задачи выполнены, проект завершен");
        }
    }
}
