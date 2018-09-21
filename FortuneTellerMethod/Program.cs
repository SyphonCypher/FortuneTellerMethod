using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FortuneTeller fortuneTeller = new FortuneTeller();

            Console.WriteLine("Welcome to the Fortune Teller! Their health will decrease by 20% after each answer you give. The Fortune Teller's health is " + fortuneTeller.GetHealth + "%");
            Console.WriteLine("What is your first name?");
            fortuneTeller.GetName = Console.ReadLine();
            fortuneTeller.Tic();

            Console.WriteLine("What is your surname?");
            fortuneTeller.GetSurname = Console.ReadLine();
            fortuneTeller.Tic();

            Console.WriteLine("What is your age?");
            fortuneTeller.GetAge = int.Parse(Console.ReadLine());
            fortuneTeller.Tic();

            Console.WriteLine("What is your birth month?");
            fortuneTeller.GetMonth = int.Parse(Console.ReadLine());
            fortuneTeller.Tic();

            Console.WriteLine("How many siblings do you have?");
            fortuneTeller.GetSiblings = int.Parse(Console.ReadLine());
            fortuneTeller.Tic();

            Console.WriteLine("Select your favorite color from the ROYGBIV spectrum. Type \"Help\" if you do not understand the acronym.");
            fortuneTeller.GetColor = Console.ReadLine().ToLower();
            fortuneTeller.Tic();
            fortuneTeller.GetHelp(fortuneTeller.GetColor);


            Console.WriteLine("{0} " + "{1} " + "will retire in " + "{2} years " + "with " + "{3} " + "in the bank, a vacation home in " + "{4}, " + "and a {5}.", fortuneTeller.GetName, fortuneTeller.GetSurname, fortuneTeller.GetAge, fortuneTeller.GetMoney(), fortuneTeller.GetLocation(), fortuneTeller.GetTranspo());
        }
    }
}
