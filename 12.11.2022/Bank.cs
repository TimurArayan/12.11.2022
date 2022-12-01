using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TumakovCalssWork
{
    public enum Type
    {
        Накопительный, Кредитный
    }
    internal class Bank
    {
        /// <summary>
        /// Поля
        /// </summary>
        private int id;
        private float balance;
        private Type type;
        private Queue<BankTransaction> mas = new Queue<BankTransaction>();

        /// <summary>
        /// Рандом
        /// </summary>
        Random rnd = new Random();

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Bank()                       
        {
            this.id = rnd.Next();                               
            this.balance = 0;
            this.type = Type.Накопительный;
        }
        public Bank(float balance)
        {
            this.id = rnd.Next();
            this.balance = balance;
        }
        public Bank(Type type)
        {
            this.id = rnd.Next();
            this.type = type;
        }
        public Bank(float balance, Type type)
        {
            this.id = rnd.Next();
            this.balance = balance;
            this.type = type;
        }

        /// <summary>
        /// Положить на счет
        /// </summary>
        /// <param name="summa">Сумма, которую мы ложим на баланс</param>
        public void Put(float summa)
        {
            BankTransaction a = new BankTransaction(summa);
            balance += summa;
            mas.Enqueue(a);
        }

        /// <summary>
        /// Снять со счета
        /// </summary>
        /// <param name="summa">Сумма, которую мы снимаем с баланса</param>
        public void Take(float summa)
        {
            if (summa <= balance)
            {
                BankTransaction a = new BankTransaction(-summa);
                balance -= summa;
                mas.Enqueue(a);
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }
        public void Print()
        {
            Console.WriteLine($"Номер счета - {id}, баланс - {balance} рублей, тип счета - {type}");
        }
        public void ShowTransaction()
        {
            foreach(BankTransaction i in mas)
            {
                Console.WriteLine(i.Info());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            StreamWriter z = new StreamWriter("transactions.txt");
            foreach(BankTransaction i in mas)
            {
                z.WriteLine(i.Info());
            }
            GC.SuppressFinalize(this);
        }


    }
}
