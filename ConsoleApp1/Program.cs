using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string name;
            int age;
            string email;
            string choise;

            Console.WriteLine("Hey,\n");
            Console.WriteLine("Have i seen you here before?\n");
            Console.WriteLine("Tel me your name and let me see if i recognize you!\n");
            name =  Console.ReadLine();

            if (name == "Gwen")
            {
                name = "BOSS";
                SayHiBoss(name);
                Console.WriteLine($"Oooh, Sorry {name}!! \n");
                Console.WriteLine($"Welcome home {name}.\n");
            }
            
            else
            {
               SayHiVisitor(name);
                Console.WriteLine("Welcome in my world!!");
                Console.WriteLine("Before we can go on, i will need to now your age.\n");
                age = Convert.ToInt32(Console.ReadLine());

                if(age < 18 )
                {
                    Console.WriteLine($"\nWhoops.. {age}? \nYou are not old enough!\n");
                    Console.WriteLine("You can come back when you are 18.\n");
                    Console.WriteLine("Please close the door when you leave!\n");
                    Console.WriteLine("\t()_()");
                    Console.WriteLine("\t(*-*)");
                    Console.WriteLine("\t()_()");
                } 

                else
                {
                    Console.WriteLine($"\n{ age}, he.. Nice!\nNow we can go on.\n");
                    Console.WriteLine("Please enter your email\n");
                    email = Console.ReadLine();
                    Console.WriteLine($"\nYou have entered: \t{email}\t as your email.\n\nIs that correct?\n(y = yes / n = no)\n");
                    choise = Console.ReadLine();

                    if (choise == "y" || choise == "Y")
                    {
                        Console.WriteLine("\nThank you for confirming your email.\n");
                        Console.WriteLine("i have to go now.\nGoodbye!");
                    }

                    else if (choise == "n" || choise == "N")
                    {
                        while (choise == "n" || choise == "N")
                        {

                            Console.WriteLine("\nPlease enter your correct email!\n");
                            email = Console.ReadLine();
                            Console.WriteLine($"\nYou have entered: \t{email}\t as your email.\nIs that correct?\n(y = yes / n = no)\n");
                            choise = Console.ReadLine();
                        }

                        while (choise == "y" || choise == "Y")
                        {
                            Console.WriteLine("\nThank you for confirming your email.\n");
                            Console.WriteLine("I have to go now.\nGoodbye!");
                            break;
                        }
                    }
                    
                    else
                    {
                        Console.WriteLine("Please only enter \"y\" or \"n\"!");                        
                    }
                }
            }
        }

        static void SayHiBoss(string name)
        {
            Console.WriteLine($"Hi, {name}");
        }

        static void SayHiVisitor(string name)
        {
            Console.WriteLine($"\nWell Hello, {name}!\n");
        }
    }
}
