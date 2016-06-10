using System;
using System.Collections.Generic;           
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
   
 //Develop a console application that will tell the user’s fortune based on data received from the user. The specifications are as follows:
            Console.WriteLine("If you allow me the opportunity, I would like to tell you your future. \n\nEnter Y/N.\n");
            string response = Console.ReadLine();
            string yes = response.ToUpper();
            while (yes == "Y")
            {
                Console.WriteLine("Enter your first name then press enter\n");
                string ans = Console.ReadLine();
                string firstName = ans.ToUpper();
                Console.WriteLine("Enter your last name then press enter.\n");
                string ans1 = Console.ReadLine();
                string lastName = ans1.ToUpper();

                Console.WriteLine("Enter your age then press enter.\n");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the month were you born ex. (January), then press enter.\n");
                string ans2 = Console.ReadLine();
                string month = ans2.ToUpper();

                Console.WriteLine("Next, you will be prompted to enter your favorite color (ROYGBIV). \n\nIf you don't know what these colors are, \nenter: \"Help\" now or press enter to continue .");
                string ans3 = Console.ReadLine();
                string colorUpper = ans3.ToUpper();

                if (colorUpper == "HELP") //Can also use (colorUpper.Equals("HELP"))
                {
                    Console.WriteLine("\nYour color options are: red, orange, yellow, green, blue, indigo or violet.\n");
                }
                Console.WriteLine("Enter your color and press enter\n");
                string colorAns = Console.ReadLine();
                string color = colorAns.ToUpper();
                Console.WriteLine("Your color " + color + " is valid!\n");

                Console.WriteLine("Enter how many siblings do you have then press enter.\n");
                int siblings = int.Parse(Console.ReadLine());

                int retire = WillRetireIn(age);
                string dollars = MoneyInBank(firstName, lastName, month);
                string place = (Location(siblings));
                string transport = GetTransportation(color);



                //Retire Program
                /*Console.WriteLine("Enter your age");
                int age = int.Parse(Console.ReadLine());
                int retire = WillRetireIn(age);
                Console.WriteLine(retire);*/

                //Money In The Bank Program
                /*Console.WriteLine("Enter the month were you born ex. (January), then press enter.");
                string ans3 = Console.ReadLine();
                string month = ans3.ToUpper();
                Console.WriteLine("Enter First Name");
                string name = Console.ReadLine();
                string firstName = name.ToUpper();
                Console.WriteLine("Enter Last Name");
                string name1 = Console.ReadLine();
                string lastName = name1.ToUpper();
                string dollars = MoneyInBank(firstName, lastName, month);
                Console.WriteLine(dollars);*/

                //Location Program
                /*Console.WriteLine("Enter amount of siblings.");
                int siblings = int.Parse(Console.ReadLine());
                string place = (Location(siblings));
                Console.WriteLine(place);*/

                //Transportation Program
                /*Console.WriteLine("Enter your color and press enter");
                string colorAns = Console.ReadLine();
                string color = colorAns.ToUpper();
                string transport = GetTransportation(color);
                Console.WriteLine(transport);*/


                Console.WriteLine("\n\t" + firstName + " " + lastName + " will retire in " + retire + " years \n\n\twith " + dollars + " in the bank, \n\n\ta vacation home in " + place + "and drive " + transport + ".\n\n");


                Console.WriteLine("Would you like to try again? Y/N");
                string yesNo1 = Console.ReadLine();
                string again = yesNo1.ToUpper();
                if (again != "Y")
                {
                    Console.WriteLine("\nMaybe next time!");
                    break;
                }

            }
        }

        //Retire Method
        static int WillRetireIn(int age)
        {
            if (age >= 1 && age <= 120 && age % 2 == 0)
            {
                return 10;
            }
            else
            {
                return 20;
            }
        }

        //Money In The Bank Method
        static string MoneyInBank(string firstName, string lastName, string month)
        {
            string monthL = month.Substring(0, 1);
            string monthL2 = month.Substring(1, 1);
            string monthL3 = month.Substring(2, 2);
            string wholeName = firstName + lastName;

            if (wholeName.Contains(monthL) == true)
            {
                return "$1.00";
            }
            if (wholeName.Contains(monthL2) == true)
            {
                return "$1,000.00";
            }
            if (wholeName.Contains(monthL3) == true)
            {
                return "$100,000.00";
            }
            else
            {
                return "$0.00";
            }
        }

        //Location Method
        static string Location(int siblings)
        {

            if (siblings == 0)
            {
                string location = "your parents house ";
                return location;
            }
            else if (siblings == 1)
            {
                string location = "Miami ";
                return location;
            }
            else if (siblings == 2)
            {
                string location = "San Fransico ";
                return location;
            }
            else if (siblings == 3)
            {
                string location = "Italy ";
                return location;
            }
            else
            {
                string location = "Utah on a farm ";
                return location;
            }
        }

        //Transportation method
        static string GetTransportation(string color)
        {

            if (color == "RED")
            {
                return "a mini pony";
            }
            else if (color == "ORANGE")
            {
                return "a BMW";
            }
            else if (color == "YELLOW")
            {
                return "a garbage truck";
            }
            else if (color == "GREEN")
            {
                return "a train";
            }
            else if (color == "BLUE")
            {
                return "a VW Beetle";
            }
            else if (color == "INDIGO")
            {
                return "a Yukon Denali";
            }
            else if (color == "VOILET")
            {
                return "a tow truck";
            }
            else
            {
                return "a short bus";
            }
        }
    }
}