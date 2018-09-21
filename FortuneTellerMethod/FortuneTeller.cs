using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerMethod
{
    class FortuneTeller
    {
        //Fields
        private string name;
        private string surname;
        private int age;
        private int month;
        private string color;
        private int siblings;
        private int health = 100;

        //Properties
        public string GetName
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string GetSurname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }

        public int GetAge
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public int GetMonth
        {
            get { return this.month; }
            set { this.month = value; }
        }

        public string GetColor
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public int GetSiblings
        {
            get { return this.siblings; }
            set { this.siblings = value; }
        }

        public int GetHealth
        {
            get { return this.health; }
            set { this.health = value; }
        }

        //Constructors
        public FortuneTeller()
        {
            //Default constructor
        }

        public FortuneTeller(string name, string surname, int age, int month, string color, int siblings)
        {
            this.GetName = name;
            this.GetSurname = surname;
            this.GetAge = age;
            this.GetMonth = month;
            this.GetColor = color;
            this.GetSiblings = siblings;
            GetHelp(color);
        }

        //Methods
        public int GetRetirement(int age)
        {
            if (age % 2 == 0)
            {
                return 10;
            }
            else
            {
                return 13;
            }
        }

        public void GetHelp(string color)
        {
            if (color == "help")
            {
                Console.WriteLine("ROYGBIV:");
                Console.WriteLine("Red");
                Console.WriteLine("Orange");
                Console.WriteLine("Yellow");
                Console.WriteLine("Green");
                Console.WriteLine("Blue");
                Console.WriteLine("Indigo");
                Console.WriteLine("Violet");
                Console.WriteLine("What is your favorite color?");
                GetColor = (Console.ReadLine().ToLower());
                Tic();
            }
        }

        public string GetLocation()
        {
            if (GetSiblings < 0)
            {
                return "Detroit";
            }
            else if (GetSiblings == 0)
            {
                return "Paris";
            }
            else if (GetSiblings == 1)
            {
                return "Rome";
            }
            else if (GetSiblings == 2)
            {
                return "Maui";
            }
            else if (GetSiblings == 3)
            {
                return "Tahiti";
            }
            else
            {
                return "Barcelona";
            }
        }

        public string GetTranspo()
        {
            switch (color)
            {
                case "red":
                    return "Ferarri 488";
                    
                case "orange":
                    return "Dodge Charger";
                    
                case "yellow":
                    return "Lamborghini Diablo";
                    
                case "green":
                    return "Toyota Hilux";
                    
                case "blue":
                    return "Plymouth Roadrunner";
                    
                case "indigo":
                    return "Chevy Corvette";
                    
                case "violet":
                    return "Ford Mustang";

                default:
                    return "no transportation";
                    
            }
        }

        public string GetMoney()
        {
            if ((month >= 1) && (month <= 4))
            {
                return "$25,000.00";
            }
            else if ((month >= 5) && (month <= 8))
            {
                return "$50,000.00";
            }
            else if ((month >= 9) && (month <= 12))
            {
                return "$100,000.00";
            }
            else
            {
                return "$0.00";
            }
        }

        public void Tic()
        {
            GetHealth = GetHealth - 20;
            Console.WriteLine("The Fortune Teller's health is " + GetHealth + "%");
            if (GetHealth <= 40)
            {
                Console.WriteLine("Would you like to replenish the Fortune Teller's health?");
                string input = Console.ReadLine().ToLower();
                if (input == "yes")
                {
                    GetHealth = 100;
                    Console.WriteLine("The Fortune Teller offers you their gratitude. Their health has been replenished to 100%");
                }
                else if (GetHealth <= 20)
                {
                    Console.WriteLine("You failed to help the Fortune Teller. Their health has been automatically restored to 100%....you monster.");
                    GetHealth = 100;
                }
                else
                {
                    
                }
            }
        }




    }
}
