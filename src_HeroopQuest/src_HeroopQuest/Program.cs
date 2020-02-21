using src_HeroopQuest.GameClasses;
using System;

namespace src_HeroopQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            Held held1 = new Held(HeldType.Barbaar,"Connan");
            Held held2 = new Held(HeldType.Tovenaar, "bart");
            Console.WriteLine(held1.AanvalsDobbelsteen);
            Console.WriteLine(held2.Naam);
        }
    }
}
