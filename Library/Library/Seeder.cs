using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   static class Seeder

    {
        private static int _counter;

        public static void GenerateRandomIndex(int counter)
        {
            Random rnd = new Random();
            _counter = rnd.Next(0, 20);
            Console.WriteLine(_counter);

        } 

            


        public class List<Utenti>
        {
        
        }



      



    }
}
