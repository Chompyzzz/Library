using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        public string titolo { get; set; }

        public string autore { get; set; }

        //public enum genere { ci guardo poi; }

        public int isbn { get; set; }

        public Book(string titolo, string autore, string genere, int isbn)
        {
            this.titolo = titolo;
            this.autore = autore;

            if (isbn < 0) isbn = isbn + 1;
            this.isbn = isbn;

        }

        public void describe()
        {

        }

        public override string ToString() 
        {
            return titolo + isbn;

        }

        public void describeBooks()
        {

        }



    }
}
