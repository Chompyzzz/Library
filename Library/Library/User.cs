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
        
        public string cf { get { return nome + cognome;  } }

        public DateTime birth { get; set; }

        public int count { get; set;  }


        public User(string nome, string cognome, string cf, DateTime birth)
        {
            nome = this.nome;

            cognome = this.cognome;

            cf = this.cf;

            birth = this.birth;

        }


        public string describe()
        {
            string outputUser = "L'utente selezionato è " + nome + " " + cognome + " \r\n" ;

            outputUser += "il suo codice fiscale è " + cf + " ed è nato il " + birth + " . \r\n" ;

            outputUser += "Attualmente ha " + count + " libri da restituire . ";

            return outputUser; 

        }


        public override string ToString()
        {
            return nome + " " + cognome ;
        }


        List<Book> ownedBook = new List<Book>();

        public int nBook( Book b )
        {
            ownedBook.Add(b);

            count = ownedBook.Count;

            return count ;
            
        }

       // public string libriPosseduti (Book b)
        

        


    }
}
