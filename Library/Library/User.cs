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

       // public string cf { get; { return nome + cognome; } }

        private int year { get; set; }
        private int month { get; set; }
        private int day { get; set; }


        DateTime dt = new DateTime();

    }
}
