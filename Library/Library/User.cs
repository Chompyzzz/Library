using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User
    {
        public string nome { get; set; }

        public string cognome { get; set; }
        
        public string cf { get; set; }//vedi seeder di jack

        public DateTime birth { get; set; }

        public int count { get; set;  }


        public User(string nome, string cognome, string cf, DateTime birth)
        {
            this.nome = nome;

            this.cognome = cognome;

            this.cf = cf;

            this.birth = birth;
        }


        public string describe()
        {
            string outputUser = "L'utente selezionato è " + nome + " " + cognome + " \r\n" ;

            outputUser += "il suo codice fiscale è " + cf + " ed è nato il " + birth + " . \r\n" ;

            outputUser += "Attualmente ha " + ownedBook.Count + " libri da restituire . ";

            return outputUser; 

        }


        public override string ToString()
        {
            return nome + " " + cognome ;
        }


        public List<Book> ownedBook = new List<Book>();// andava messa public

        public int nBook( Book b )// questa non la capisco
        {
            ownedBook.Add(b);

            count = ownedBook.Count;

            return count ;
            
        }

        public string describeBooks(Book b)
        {
            string output = "L' utente possiede i seguenti libri: " + System.Environment.NewLine;
            
            output += b.ToString(); //momentaneo, bisogna far vedere tutti i libri e non solo l'ultimo come succede.

            return output;
        }

        


    }
}
