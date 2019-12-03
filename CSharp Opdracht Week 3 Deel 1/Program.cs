using System;
using System.Collections.Generic;

namespace CSharp_Opdracht_Week_3_Deel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVragen> vragenlijst = CreateVragen();
            foreach (IVragen vraag in vragenlijst)
            {
                vraag.readQuestion();
                String answer = Console.ReadLine();
                if (vraag.checkAntwoord(answer)) Console.WriteLine("Correct"); else Console.WriteLine("WRONG");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        public static List<IVragen> CreateVragen()
        {
            List<IVragen> vragenLijst = new List<IVragen>();
            IVragen vraag1 = new OpenVraag("Wat is mij naam?", "Mohamed", 1,"Persoonlijk");
            vragenLijst.Add(vraag1);

            List<string> opties = new List<string> { "Mohamed", "Repelsteeltje", "Rashied", "Soefian" };
            IVragen vraag2 = new MultipleChoiceVragen("Hoe heet ik?", "Mohamed", opties, 1,"Persoonlijk");
            vragenLijst.Add(vraag2);

            opties = new List<string> { "19", "20", "21", "22" };
            IVragen vraag3 = new MultipleChoiceVragen("Hoe oud ben ik?", "21", opties, 2,"Persoonlijk");
            vragenLijst.Add(vraag3);

            IVragen vraag4 = new OpenVraag("Wat heb ik?", "niks", 3,"Persoonlijk");
            vragenLijst.Add(vraag4);
            return vragenLijst;
        }
    }
}
