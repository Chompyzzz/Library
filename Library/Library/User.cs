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

            outputUser += "il suo codice fiscale è " + cf + " ed è nato il " + birth;

            return outputUser; 

        }

        public override string ToString()
        {
            return nome + " " + cognome ;
        }

       // public string libriPosseduti (Book b)
        

        


    }
}
