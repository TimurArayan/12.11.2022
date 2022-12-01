using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static HomeWork.Task;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace HomeWork
{
    internal class Task
    {


        public string description { get; set; }
        public DateTime deadline { get; set; }
        public Person customer { get; set; }
        public Person executor { get; set; }
        public TaskStatus status { get; set; }
        public Report report { get; set; }
        public string speciality { get; set; }

        public Task(string description, string speciality)
        {
            this.description = description;
            this.speciality = speciality;
            this.status = TaskStatus.Назначена;
        }

        public bool Test()
        {
            Console.WriteLine($"{DateTime.Now} {customer} отдал задачу {description} {executor}");

                if (speciality.Equals(executor.speciality))
                {
                    Console.WriteLine($"{executor.name} принял задачу {description} в {DateTime.Now}");
                    status = TaskStatus.В_работе;
                    report = new Report(description, DateTime.MaxValue, executor);
                    report.Give();
                    status = TaskStatus.Выполнена;
                    Console.WriteLine($"{executor.name} выполнил задачу {description} в {DateTime.Now}\n");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{executor.name} не принял задачу, так как он  - {executor.speciality}, а у задачи - {speciality}\n");
                    return false;
                }
        }
    }
}
