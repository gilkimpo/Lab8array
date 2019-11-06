using System;
using System.Text.RegularExpressions;

namespace arraylistcollections1030
{
    class Program
    {
        static void Main(string[] args)

            //parallel array for consise data retrieval
        {
            
            Regex foodRegex = new Regex(@"^food");//regex to make sure user input is either food or hometown
            Regex hometownRegex = new Regex(@"^hometown");
            Regex bothRegex=new Regex(@"^both");

            string[] names = {
                "jacob",//names [0]
                "A'keem",//names [1]
                "Draymond Green", //names [2]
                "Harleen Quinzel",//names [3]
                "Earvin Johnson", //names[4]
                "Swifty",//names[5]
                "Emma Bunton",//names[6]
                "Jen Garner",//namses[7]
                "Diana Prince",//names[8]
                "Barry Allen"//names[9]
            };
            string[] food = { "cookies",
                "ice cream",
                "thai", 
                "pie",
                "nachos",
                "anything banana",
                "bangers and mash",
                "filipino food",
                "Steak" ,
                "Fried Chicken"
            };//food [0,1,2,3,4,5,6,7,8,9]
            string[] hometown = { "merrillville",
                "Detroit",
                "Saginaw",
                "Gotham City",
                "East Lansing",
                "Nashville",
                "London",
                "Charleston",
                "Themyscira",
                "Central City"
            };//hometown[0,1,2,3,4,5,6,7,8,9]
            string GoAgain;
            do
            {
                Console.WriteLine("Hi! Which student would you like to learn about? Enter any number between 1-10");

                try
                {//making sure user input is valid with try/catch

                    string userInput = Console.ReadLine();
                    int input = int.Parse(userInput);
                    Console.WriteLine($"That student is: {names[input - 1]}");//input minus 1 so user doesn't have to use 0 as choice
                    
                    
                        Console.WriteLine("\nAnd what would you like to know about  that person, their hometown, or  favorite food, or both?");
                        string userInput2 = Console.ReadLine().ToLower();
                        if (userInput2 == "food")
                        {
                            Console.WriteLine($"\nGreat, their favorite food is {food[input - 1]}.");
                        }
                        if (userInput2 == "hometown")
                        {
                            Console.WriteLine($"\nOK, stalker, they are from {hometown[input - 1]}.");
                        }
                        else if (userInput2 == "both")
                        {
                            Console.WriteLine($"\nWell, fave food is {food[input - 1]}, and , stalker, they are from {hometown[input - 1]}.");
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
