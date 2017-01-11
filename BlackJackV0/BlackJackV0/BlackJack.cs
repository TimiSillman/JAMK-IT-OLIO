using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
    class BlackJack
    {
        static void Main()
        {
            System.Console.WriteLine("*** BlackJack! ***");
            do
            {
                Random rnd = new Random();
                int myNumber;
                string theirNumber;
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
                //reading and converting 
                theirNumber = Console.ReadLine();
                //comparing that given umber is valid

                if (theirNumber == "x" || theirNumber == "exit") { break; }

                    if (Int32.Parse(theirNumber) < 1 || Int32.Parse(theirNumber) > 21)
                    {
                        Console.WriteLine("The given number is out of limits, try again.");
                    }

                        myNumber = rnd.Next(1, 21);
                        //comparing
                        if (Int32.Parse(theirNumber) >= myNumber && Int32.Parse(theirNumber) <= 21)
                        {
                            System.Console.WriteLine("You win.");
                        }
                        else
                        {
                            System.Console.WriteLine("You lose.");
                        }

            } while (true);
        }
    }
  }
