using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovCalssWork
{
    internal class BankTransaction
    {
        /// <summary>
        /// Поля
        /// </summary>
        readonly DateTime data = DateTime.Now;
        readonly float summa;
        public BankTransaction(float summa)
        {
            this.summa = summa;
        }
        /// <summary>
        /// Тнормация о транзакции
        /// </summary>
        /// <returns>Возвращает дату и сумму</returns>
        public string Info()
        {
            return $"{data}, {summa}";
        }
    }
}
