using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]number= { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits = { "Hjärter", "Spader", "Ruter", "Klöver" };

            int[] number2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits2 = { "Hjärter", "Spader", "Ruter", "Klöver" };

            Random random = new Random();
            Random random2 = new Random();

            bool något = true;

            while (något == true)
            {
                int rndmvalue = number[random.Next(0, 11)];
                string rndmsuit = suits[random.Next(0, 4)];

                
                //Behövs bara för första rundan
                int rndmvalue2 = number[random.Next(0, 11)];
                string rndmsuit2 = suits[random.Next(0, 4)];
                int rdmvalue3 = number[random.Next(0, 11)];
                int rdmvalue4 = number[random.Next(0, 11)];  

                Console.WriteLine("Välkommen till Black Jack");
                Console.WriteLine($"Dinna startkort kommer vara {rndmsuit} {rndmvalue} och {rndmsuit2} {rndmvalue2}");
                Console.WriteLine($"Du har nu {rndmvalue + rndmvalue2} poäng");
                Console.WriteLine($"Datorn fick {rdmvalue4 + rdmvalue3} poäng");
                Console.WriteLine("Vill du köra igen (y/n)");
                string svar = Console.ReadLine();
                svar.ToLower();

                int playervalue = rndmvalue + rndmvalue2;
                int PCvalue = rdmvalue3 + rdmvalue4;


                
                while (svar == "y")
                {
                    int rdmvalue6 = number[random.Next(0, 11)];

                    Console.WriteLine($"Ditt nya kort blir en {suits[random.Next(0, 4)]} {rdmvalue6}");
                    Console.WriteLine($"Du har nu {number[random.Next(0, 11)] + rdmvalue6} poäng");
                    Console.WriteLine("Vill du köra igen (y/n)");
                    string svar2 = Console.ReadLine();

                    int playerresults = number[random.Next(0, 11)] + playervalue;

                    while (playerresults > 21)
                    {
                        något = false;
                        break;
                    }

                    while(playerresults == 21)
                    {
                        något = false;
                        break;
                    }

                    while (svar2 == "n")
                    {
                        int rndmvalue8 = number[random.Next(0, 11)];

                        Console.WriteLine($"Du fick {playervalue} poäng");
                        Console.WriteLine($"Datorn fickk {rndmvalue8 + PCvalue} poäng");

                        int pcreslults = rndmvalue8 + PCvalue;

                        if (pcreslults > 21)
                        {
                            något = false;
                            break;
                        }

                        if(pcreslults > playerresults)
                        {
                            något = false;
                            break;
                        }
                        if (pcreslults < playerresults)
                        {
                            något = false;
                            break;
                        }
                        if (playervalue > 21)
                        {
                            något=false;
                            break;
                        }
                        
                    }
                }

                while (svar == "n")
                {
                    int rndmvalue7 = number[random.Next(0, 11)];

                    Console.WriteLine($"Du fick {playervalue} poäng");
                    Console.WriteLine($"Datorn fick {rndmvalue7 + PCvalue} poäng");
                    
                    int pcreslults = rndmvalue7 + PCvalue;

                    if(pcreslults > 21)
                    {
                        något = false;
                        break;
                    }

                    if (pcreslults > playervalue)
                    {
                        något = false;
                        break;
                    }

                    if (pcreslults < playervalue)
                    {
                        något = false;
                        break;
                    }

                    if (playervalue > 21)
                    {
                        något = false;
                        break;
                    }
                    
                }
            }
            while(något== false)
            {
                Console.WriteLine("Test");
                
            }
        }
    }
}

