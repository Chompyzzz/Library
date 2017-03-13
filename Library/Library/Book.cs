﻿using System;
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

        public string genere { get; set; }

        public string isbn { get; set; }

        public bool prestato { get; set; } = false;
        

        public Book(string titolo, string autore, string genere, string isbn)
        {
            this.titolo = titolo;
            this.autore = autore;

            this.genere = genere;
            this.isbn = isbn;
        }

        public string describe()
        {
            string output = "Il libro scelto è un " + genere + " di nome " + titolo + "\r\n";
            output += " scritto da " + autore + " \r\n";
            output += " Ed ha codice " + isbn + ". \r\n";

            if (!prestato)
            {
                output += "Il libro è disponibile per essere prestato.";

            }
            else  
            {
                output += " Il libro è già in prestito.";
            }


            return output;
        }

        public override string ToString() 
        {
            return titolo + isbn;

        }

        public string presta(User u)
        {
            prestato = true;
            string output = " Il libro è stato prestato all' utente " + u.cognome + " " + u.nome;

            return output;
        }
 
    }
}
