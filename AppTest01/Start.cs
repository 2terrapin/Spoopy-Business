using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bikeclub
{
    class Start
    {
        //Needs these:
        public static string Pname = null;


        public static void Intro()
        {
            string qu01 = null;
            string doop = null;
            //string Pname = null;
            string goat = null;
            Console.WriteLine("Hello, Welcome to the Bicycle Club official game!");
            Console.WriteLine("Are you cool and tough enough (like kenny)? Are you Ready to join our club? ");
            Console.WriteLine(" ");
            Console.WriteLine("Press the any key to continue (Unless you're scared)?");
            Console.ReadKey();
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("If this were a TV show they'd give our club a cool name like 'Sons of Redundancy'\n (press enter to continue)");
            Console.ReadLine();
            Console.Clear();
            Dialog("Before we admit you to our super secret club please tell me your name?", "red");
            Pname = Console.ReadLine();
            Console.WriteLine($"{Pname} is a really stupid name. Anyway, let's begin. Please ascend onto your bicycle and prepare for the adventure!");
            Console.WriteLine("Press the Any Key to Continue:");
            Console.ReadKey();
            Console.Write("\n You begin on your fantasic jounrey to be the best bicyle club member in the world. \n\n As you move along the road a smelly stranger approaches. He asks \n");
            Dialog("\"Have you seen the spoopy ghost?\"", "green");
            Dialog("How do you answer? 1) Yes  2) No  3) I don't know  4) ignore the smelly man and walk away", "red");
            Console.WriteLine(" ");
            qu01 = Console.ReadLine();

            //qu01 possibilties
            if (qu01 == "1")
            {
                Dialog("\"You're Lucky, All I saw was the puggo!\"", "green");
                Dialog("Whats Your Shoe?", "green");
                doop = Console.ReadLine();
                Dialog($"Okay {doop}", "green");
                Console.ReadKey();
            }
            else if (qu01 == "2")
            {
                Dialog("Figures, because your eyes are broken.", "green");
                Dialog($"{Pname} is smelly in your pants. Show the titties?", "green");
                Console.WriteLine("Yes or No?");
                goat = Console.ReadLine();

                if (goat == "yes")
                {
                    Console.WriteLine($"Fuck you {Pname}!");
                }
                else
                {
                    Console.WriteLine("Poop in your mouth girl");
                }
                Start.SitOne();
            }
            else if (qu01 == "3")
            {
                Dialog("Figures, You look confused just in general.", "green");
            }
            else if (qu01 == "4")
            {
                Dialog("You can't ignore me you fruit cup", "green");
                Console.ReadKey();
                Start.Ignor();
            }
            else
            {
                Dialog("WRONG ANSWER - Game Over YOU DIED!!", "green");
            }
        }

        public static void Dialog(string message, string color)
        {
            if (color == "red")
            { Console.ForegroundColor = ConsoleColor.Red; }
            else if (color == "green")
            { Console.ForegroundColor = ConsoleColor.Green; }
            else if (color == "yellow")
            { Console.ForegroundColor = ConsoleColor.Yellow; }
            else if (color == "blue")
            { Console.ForegroundColor = ConsoleColor.Blue; }
            else
            { Console.ForegroundColor = ConsoleColor.White; }

            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void LegOne()
        {
            Console.WriteLine("Ruby Loves You");
        }

        public static void Ignor()
        {
            Dialog($" NAME, it appears the man does not beleive you. \n You must now fight to the death!", "green");
            Console.ReadKey();
        }

        public static void SitOne()
        {
            Dialog($" \n You said your name was {Pname}, \n I guess that means you love pugs.", "green");
            Console.ReadKey();
            Console.WriteLine("Anyways, you better get a move on, here's a gift!", "green");
            Console.ReadKey();
            Dialog($"\n {Pname} received a BANANA SLING", "blue");
        }
    }
}
