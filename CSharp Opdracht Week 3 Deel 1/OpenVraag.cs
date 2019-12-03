using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Opdracht_Week_3_Deel_1
{
    class OpenVraag : IVragen
    {
        public int Moeilijkheidsgraad { get; set; }
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public string Categorie { get; set; }

        public OpenVraag(string vraag, string antwoord, int moeilijkheidsgraad, string categorie)
        {
            Vraag = vraag;
            Moeilijkheidsgraad = moeilijkheidsgraad;
            Antwoord = antwoord;
            Categorie = categorie;
        }

        public bool checkAntwoord(string antwoord)
        {
            if (Antwoord == antwoord)
                return true;
            return false;
        }
        public void readQuestion()
        {
            Console.WriteLine("Catergorie: "+Categorie);
            Console.WriteLine("Vraag: "+Vraag);
        }
    }
}
