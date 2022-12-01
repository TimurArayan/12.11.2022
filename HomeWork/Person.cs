using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Person
    {
        public string name { get; set; }
        public string speciality { get; set; }
        
        public Person(string name, string speciality)
        {
            this.name = name;
            this.speciality = speciality;
        }
    }
}
