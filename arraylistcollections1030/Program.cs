using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace arraylistcollections1030
{
    class Program
    {
        static void Main(string[] args)

        //Lists
        {

            Regex foodRegex = new Regex(@"^food");//regex to make sure user input is either food or hometown
            Regex hometownRegex = new Regex(@"^hometown");
            Regex bothRegex = new Regex(@"^both");

            List<string> studentNames = new List<string>{"jacob",
                "A'keem",
                "Draymond Green",
                "Harleen Quinzel",
                "Earvin Johnson",
                "Swifty",
                "Emma Bunton",
                "Jen Garner",
                "Diana Prince",
                "Barry Allen" };

            List<string> food = new List<string> { "cookies",
            "ice cream",
            "thai",
            "pie",
             "nachos",
                "anything banana",
                "bangers and mash",
                "filipino food",
                "Steak" ,
                "Fried Chicken"};

            List<string> hometown = new List<string> { "merrillville",
                "Detroit",
                "Saginaw",
                "Gotham City",
                "East Lansing",
                "Nashville",
                "London",
                "Charleston",
                "Themyscira",
                "Central City" };

            List<string> quote = new List<string> { "'Switches...why'd it have to be switches..'",
                "'I must break you'",
                "'Gooooooooooo GREEEEEEEN!!!!",
                "'Hi ya Puddin'",
                "'GOOOO WHIIIITE'",
                "'You need to calm down'",
                "'So tell me what you want, what you really really want...'",
                "'What's in your wallet? Also, I love Gil btw'",
                "'I am woman, hear me roar'",
                "'Flash, a ah, Savior of the universe....Flash, a ah, he'll save every one of us'" };


            string GoAgain, WillAdd, addAnother;
            do
            {
                Console.WriteLine("Hi! Which student would you like to learn about? Enter any number between 1-10");
                
                try
                { 
                    string userInput = Console.ReadLine();
                    int input = int.Parse(userInput);
                    Console.WriteLine($"That student is: {studentNames[input - 1]}");//input minus 1 so user doesn't have to use 0 as choice

                    Console.WriteLine("\nAnd what would you like to know about  that person, their hometown, or  favorite food, or quote ?");
                    string userInput2 = Console.ReadLine().ToLower();
                    if (userInput2 == "food")
                    {
                        Console.WriteLine($"\nGreat, their favorite food is {food[input - 1]}.");
                    }
                    if (userInput2 == "hometown")
                    {
                        Console.WriteLine($"\nOK, stalker, they are from {hometown[input - 1]}.");
                    }
                    else if (userInput2 == "quote")
                    {
                        Console.WriteLine($"\nWell, they've been known to say : {quote[input - 1]} .");
                    }

                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("That is not a valid number, it's out of range. please try again.");

                }
                catch (FormatException)
                {
                    Console.WriteLine("You entered something other than what i asked for , please try again.");

                }
                catch (Exception)
                {
                    Console.WriteLine("\nSorry, that's not valid. please try again.");
                }

                try
                {
                    
                        Console.WriteLine("\nWould you like to add another student, including their personal info?");
                        WillAdd = Console.ReadLine().ToLower();
                        if (WillAdd == "y")
                        {
                            Console.WriteLine("Please enter student name");
                            string input = Console.ReadLine();
                            studentNames.Add(input);
                            if (string.IsNullOrEmpty(input))
                            {
                                Console.WriteLine("oops, you can't just put a space");
                            }
                            Console.WriteLine("\nPlease enter their town");
                            string town = Console.ReadLine();
                            hometown.Add(town);
                            Console.WriteLine("\nPlease tell me their go-to food");
                            string gotofood = Console.ReadLine();
                            food.Add(gotofood);
                            Console.WriteLine("\nPlease enter a quote for them");
                            string saying = Console.ReadLine();
                            quote.Add(saying);
                           
                                       
                                                
                        if (string.IsNullOrEmpty(town))
                        {
                            Console.WriteLine("oops, you can't just put a space");
                        }
                        if (string.IsNullOrEmpty(gotofood))
                        {
                            Console.WriteLine("oops, you can't just put a space");
                        }
                        if (string.IsNullOrEmpty(saying))
                        {
                            Console.WriteLine("oops, you can't just put a space");
                        }
                    }                           
                            if (WillAdd == "n")
                            {
                                Console.WriteLine("\nThank you, next");
                            }                        
                }
                catch (FormatException)
                {
                    Console.WriteLine("not what i asked for");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("try again please");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("A'Keem, what are you trying to do here?");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("IDK even what you did ");
                }
                               
                //if exception is caught, will go on to next question to try to start program over
                //will loop a prompt without try catch
                do
                    {                                        
                        Console.WriteLine("\nWould you like to ask about someone else?");
                        GoAgain = Console.ReadLine().ToLower();    
                             if (GoAgain =="n")
                             {
                                Console.WriteLine("\nOk, goodbye!");
                             }
                            if (GoAgain=="y")
                             {
                                Console.WriteLine("\nOk, I'll startover over for you.");
                                Console.WriteLine("");
                             }
                    
                    }
                     while (GoAgain != "y" && GoAgain!= "n");//loop prompt so see if user will keep asking about students. forces exit or startover

            } while (GoAgain == "y");       //if user wishes to keep going, whole process starts over    
                                               
        }
               

    }
}
