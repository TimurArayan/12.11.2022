using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovHomeWork
{
    internal class Song
    {

        /// <summary>
        /// Поля
        /// </summary>
        string name;
        string author;
        Song prev;

        /// <summary>
        /// Первый контурктор
        /// </summary>
        public Song(string name, string author)
        {
            this.name = name;
            this.author = author;
            this.prev = null;
        }

        /// <summary>
        /// Второй констурктор
        /// </summary>
        /// <param name="name"></param>
        /// <param name="author"></param>
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }

        ///Была ошибка ""Song" не содержит конструктор, который принимает аргументы 0", ее можно исправиь создав конструктор, куда ничего не надо подавать
        
        public Song()
        {
            this.name = null;
            this.author = null;
            this.prev = null;
        }
    }
}
