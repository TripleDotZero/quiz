using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Opdracht_Week_3_Deel_1
{
    public interface IVragen
    {
        int Moeilijkheidsgraad { get; set; }
        string Vraag { get; set; }
        string Antwoord { get; set; }
        string Categorie { get; set; }
        bool checkAntwoord(string antwoord);
        void readQuestion();
    }
}
