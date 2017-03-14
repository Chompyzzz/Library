﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    static class Seeder

    {

        static Random rnd = new Random();




        static string[] nomi = { "Carlo", "Gianlu", "Bensi", "Antonio", "Bughyman", "Parmigiano", "Rondo", "Mariuso", "Ferdinando", "Rodrigo", "Diego", "Tasso", "Luca", "Chompy", "DeboraH", "Bonino", "Gabriele", "Fabio", "Tommaso", "Piano" };

        static string[] cognomi = { "Ru", "Ghost", "Forte", "Cannonau", "GomezPetrillo", "Fallax", "GonzagaNebbiante", "Guastalla", "Poliuretano", "LaCipolla", "MegaFaggot", "Bach", "HHH", "Manganaro", "Moro", "Picchiato", "Cattato", "Scuro", "DiversamenteEtero" };

        static string[] cf = { "KLM23ZZZ34L2", "DHU45SGF57F4", "SHG479HAL89S7", "HFK25AWT77F6", "SCE24EFS77G3", "WDS46EGS56", "ADH45DHR67F2", "WDG98EBA45H8", "WDH45JSK67K9", "WDH56JNS89E4", "WSD34FRD56G6", "WSA45FED67R9", "ES08EFD98B8", "WAS34FNC89O0", "WED67FDG45G8", "WED26RTG67S2", "WER45FCD67W2", "SCF23RFS46T6", "ERT56YTR56W3", "KOL36POL90I9" };


        static string[] titolo = { "Anna Karenina", "I Buddenbrook", "Moby Dick", "Memorie di Adriano", "Lettere ad una professoressa", "Cent'anni di solitudine", "Lolita", "Don Chisciotte della Mancia", "Il conte di Montecristo", "Il Gattopardo", "1984", "I fratelli Karamazov", "David Copperfield", "Alla ricerca del tempo perduto", "Bel-Ami", "Il Rosso e il Nero", "Il processo", "La storia", "Cime tempestose", "Madame Bovary" };

        static string[] autore = { "Lev Tolstoj", "Thomas Mann", "Herman Melville", "Marguerite Yourcenar", "I ragazzi di Don Milani", "Gabriel García Márquez", "Vladimir Nabokov", " Miguel de Cervantes", "Alexandre Dumas", "Giuseppe Tomasi di Lampedusa", "George Orwell", "Fedor Dostoevskij", "Charles Dickens", "Marcel Proust", "Guy de Maupassant", "Stendhal", "Franz Kafka", "Elsa Morante", "Emily Brontë", "Gustave Flaubert" };

        static string[] isbn = { "23435", "23545", "57212", "26572", "14562", "14576", "21462", "54876 ", "72547", "46246", "56731", "12567", "14683", "24367", "13467", "13489", "76521", "45763", "87223", "46514" };

        static string[] genere = { "Giallo", "Romanzo formativo", "Giallo", "Thriller", "Romanzo rosa", "Narrativa", "Fantasy", "Fantascientifico", "Storico", "Ghisa" };


        public static void GenerateBook()
        {
            for (int i = 0; i < 20; i++)
            {
     
                Book b = new Book(titolo[rnd.Next(0, 20)], autore[rnd.Next(0,20)], genere[rnd.Next(0,10)], isbn[rnd.Next(0,20)] );
                
                Book[i] Libri = b;
                      
            }
        }

    }








    }

