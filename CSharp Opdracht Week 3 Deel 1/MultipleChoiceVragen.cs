using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Opdracht_Week_3_Deel_1
{
    public class MultipleChoiceVragen : IVragen
    {
        public int Moeilijkheidsgraad { get; set; }
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
        public string Categorie { get; set; }
        public List<string> OptieLijst;

        public MultipleChoiceVragen(string vraag, string antwoord, List<string>optieList, int moeilijkheidsgraad, string categorie)
        {
            Vraag = vraag;
            Moeilijkheidsgraad = moeilijkheidsgraad;
            Antwoord = antwoord;
            OptieLijst = optieList;
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
            Console.WriteLine("Catergorie: " + Categorie);
            Console.WriteLine("Vraag: " + Vraag);
            string opties = "";
            foreach(string str in OptieLijst)
                opties += " " + str;
            Console.WriteLine("Opties: " + opties);
        }
    }
}
