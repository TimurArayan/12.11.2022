using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Report
    {
        public string text { set; get; }
        public DateTime deadline { set; get; }
        public Person executor { set; get; }

        public Report(string text, DateTime date, Person executor)
        {
            this.text = text;
            this.deadline = date;
            this.executor = executor;
        }

        public void Give()
        {
            Console.WriteLine($"{executor.name} прислал отчет по {text} в {DateTime.Now}");
            
        }
    }
}
