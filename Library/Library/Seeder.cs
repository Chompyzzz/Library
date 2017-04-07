using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Library
{
    static class Seeder

    {

        static Random rnd = new Random();
        

        static string[] nomi = { "Carlo", "Gianlu", "Bensi", "Antonio", "Bughyman", "Parmigiano", "Rondo", "Mariuso", "Ferdinando", "Rodrigo", "Diego", "Tasso", "Luca", "Chompy", "DeboraH", "Bonino", "Gabriele", "Fabio", "Tommaso", "Piano" };

        static string[] cognomi = { "Ru", "Ghost", "Forte", "Cannonau", "GomezPetrillo", "Fallax", "GonzagaNebbiante", "Guastalla", "Poliuretano", "LaCipolla", "MegaFaggot", "Bach", "HHH", "Manganaro", "Moro", "Picchiato", "Buselli", "Calcestruzzo", "Brazorf", "Brambilla" };

        static string[] cf = { "KLM23ZZZ34L2", "DHU45SGF57F4", "SHG479HAL89S7", "HFK25AWT77F6", "SCE24EFS77G3", "WDS46EGS56", "ADH45DHR67F2", "WDG98EBA45H8", "WDH45JSK67K9", "WDH56JNS89E4", "WSD34FRD56G6", "WSA45FED67R9", "ES08EFD98B8", "WAS34FNC89O0", "WED67FDG45G8", "WED26RTG67S2", "WER45FCD67W2", "SCF23RFS46T6", "ERT56YTR56W3", "KOL36POL90I9" };



        static string[] titolo = { "Anna Karenina", "I Buddenbrook", "Moby Dick", "Memorie di Adriano", "Lettere ad una professoressa", "Cent'anni di solitudine", "Lolita", "Don Chisciotte della Mancia", "Il conte di Montecristo", "Il Gattopardo", "1984", "I fratelli Karamazov", "David Copperfield", "Alla ricerca del tempo perduto", "Bel-Ami", "Il Rosso e il Nero", "Il processo", "La storia", "Cime tempestose", "Madame Bovary" };

        static string[] autore = { "Lev Tolstoj", "Thomas Mann", "Herman Melville", "Marguerite Yourcenar", "I ragazzi di Don Milani", "Gabriel García Márquez", "Vladimir Nabokov", " Miguel de Cervantes", "Alexandre Dumas", "Giuseppe Tomasi di Lampedusa", "George Orwell", "Fedor Dostoevskij", "Charles Dickens", "Marcel Proust", "Guy de Maupassant", "Stendhal", "Franz Kafka", "Elsa Morante", "Emily Brontë", "Gustave Flaubert" };

        static string[] isbn = { "234334345", "5634257384", "572123629", "265724759", "729414562", "264814576", "3627921462", "2847954876 ", "263872547", "2749546246", "173956731", "472912567", "217414683", "382724367", "729413467", "472913489", "273876521", "2744545763", "235687223", "465143489" };

        static string[] genere = { "Giallo", "Romanzo formativo", "Horror", "Thriller", "Romanzo rosa", "Narrativa", "Fantasy", "Fantascientifico", "Storico", "Ghisa" };


        public static void GenerateBook(ListBox t)
        {

            for (int i = 0; i < 20; i++)
            {

                Book b = new Book(titolo[i], autore[i], genere[rnd.Next(0, genere.Length)], isbn[i]);

                t.Items.Add(b);
            }
        }


        public static void GenerateUser(ListBox l)
        {
            for (int i = 0; i < 20; i++)
            {
                DateTime birth = new DateTime(rnd.Next(1996, 2002), rnd.Next(1, 12), rnd.Next(1, 30));
                User u = new User(nomi[rnd.Next(0,nomi.Length)], cognomi[rnd.Next(0, cognomi.Length)], cf[rnd.Next(0, cf.Length)] , birth.Date);

                l.Items.Add(u);            
            }
        }

    }
}








    

