using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]number= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits = { "Hjärter", "Spader", "Ruter", "Klöver" };

            Random random = new Random();

            int rndmvalue = number[random.Next(0, 11)];
            string rndmsuit = suits[random.Next(0,4)];

            //Behövs bara för första rundan
            int rndmvalue2 = number[random.Next(0,11)];
            string rndmsuit2 = suits[random.Next(0,4)];

            bool något = true;

            while (något = true)
            {
                Console.WriteLine("Välkommen till Black Jack");
                Console.WriteLine($"Dinna startkort kommer vara {rndmsuit} {rndmvalue} och {rndmsuit2} {rndmvalue2}");
                Console.WriteLine($"Du har nu {rndmvalue + rndmvalue2} poäng");

            }

        }
    }
}

