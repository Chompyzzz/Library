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

        public static void GenerateRandomIndex()
        {

            Random rnd = new Random();
            _counter = rnd.Next(0, 20);
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(_counter);
            }

        }

        public static void UserCharacteristics()
        {
            string[] nomi = { "Carlo", "Gianlu", "Bensi", "Antonio", "Bughyman", "Parmigiano", "Rondo", "Mariuso", "Ferdinando", "Rodrigo", "Diego", "Tasso", "Luca", "Chompy", "DeboraH", "Bonino", "Gabriele", "Fabio", "Tommaso", "Piano" };

            string[] cognomi = { "Ru", "Ghost", "Forte", "Cannonau", "GomezPetrillo", "Fallax", "GonzagaNebbiante", "Guastalla", "Poliuretano", "LaCipolla", "MegaFaggot", "Bach", "HHH", "Manganaro", "Moro", "Picchiato", "Cattato", "Scuro", "DiversamenteEtero" };

            string[] cf = { "KLM23ZZZ34L2", "DHU45SGF57F4", "SHG479HAL89S7", "HFK25AWT77F6", "SCE24EFS77G3", "WDS46EGS56", "ADH45DHR67F2", "WDG98EBA45H8", "WDH45JSK67K9", "WDH56JNS89E4", "WSD34FRD56G6", "WSA45FED67R9", "ES08EFD98B8", "WAS34FNC89O0", "WED67FDG45G8", "WED26RTG67S2", "WER45FCD67W2", "SCF23RFS46T6", "ERT56YTR56W3", "KOL36POL90I9" };

            Console.WriteLine(nomi[2]);
        }

        public static void BookCharacteristics()
        {
            string[] titolo = { "Anna Karenina", "I Buddenbrook", "Moby Dick", "Memorie di Adriano", "Lettere ad una professoressa", "Cent'anni di solitudine", "Lolita", "Don Chisciotte della Mancia", "Il conte di Montecristo", "Il Gattopardo", "1984", "I fratelli Karamazov", "David Copperfield", "Alla ricerca del tempo perduto", "Bel-Ami", "Il Rosso e il Nero", "Il processo", "La storia", "Cime tempestose", "Madame Bovary" };

            string[] autore = { "Lev Tolstoj", "Thomas Mann", "Herman Melville", "Marguerite Yourcenar", "I ragazzi di Don Milani", "Gabriel García Márquez", "Vladimir Nabokov", " Miguel de Cervantes", "Alexandre Dumas", "Giuseppe Tomasi di Lampedusa", "George Orwell", "Fedor Dostoevskij", "Charles Dickens", "Marcel Proust", "Guy de Maupassant", "Stendhal", "Franz Kafka", "Elsa Morante", "Emily Brontë", "Gustave Flaubert" };
            
        }

    }








    }

