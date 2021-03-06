﻿using System;
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

        public string cf { get; set; }  

        public DateTime birth { get; set; }

        public List<Book> ownedBook = new List<Book>();


        public User(string nome, string cognome, string cf, DateTime birth)
        {
            this.nome = nome;

            this.cognome = cognome;

            this.cf = cf;

            this.birth = birth;
        }


        public string describe()
        {
            string outputUser = "L'utente selezionato è " + nome + " " + cognome + Environment.NewLine  ;

            outputUser += "il suo codice fiscale è " + cf + " ed è nato il " + birth.ToShortDateString() + Environment.NewLine ;

            outputUser += "Attualmente ha " + ownedBook.Count + " libri da restituire " ;

            return outputUser; 

        }


        public override string ToString()
        {
            return nome + " " + cognome ;
        }


        public string describeBooks(Book b)
        {
            string output;

            if (ownedBook.Count != 0)
            {
                output = "L' utente possiede i seguenti libri: " + System.Environment.NewLine + System.Environment.NewLine ;
               
            }
            else
            {
                output = "L'utente non possiede ancora alcun libro.";
            }

            for (int i = 0; i < ownedBook.Count; i++)
            {
                output += (i+1) + ". " + ownedBook[i].ToString() + Environment.NewLine;
            }

            return output;
        }
    }
}
