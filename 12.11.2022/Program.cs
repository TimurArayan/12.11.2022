using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovCalssWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank x = new Bank(Type.Кредитный);
            x.Print();
            x.Put(1000);
            x.Take(500);
            x.Print();
            x.ShowTransaction();
            x.Dispose();
        }
    }
}
