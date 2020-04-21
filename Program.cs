using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
             Random random = new Random();
            int randomNumber = random.Next(1, 11);
            int randomNumber2 = random.Next(1, 21);
            int randomNumber3 = random.Next(1, 51);
            int guess;
            int numberofGuesses = 0;
            bool gameOver = false;
            string input ="";
            Console.WriteLine("This is a number geusing game, you have three level to choose from ");
            Console.WriteLine("Type EASY, MEDIUM or HARD to choose level");
            input = Console.ReadLine();
            if(input == "EASY"){
                Console.WriteLine("In this level you have to guess between 1 to 10 and you have maximum of 6 attempt");
                 Console.WriteLine("type in your guess number! ");
                  while (gameOver == false)
                   {
                guess = Convert.ToInt32(Console.ReadLine());
                numberofGuesses++; 
               
                if(guess != randomNumber && numberofGuesses == 6)
                {
                    
                    Console.WriteLine("you couldn't figurre out the number in 6 attempt?!  YOU LOSE!! ");
                    gameOver = true;
                }
                else if(guess == randomNumber)
                {
                    Console.WriteLine("that's it YOU WIN!! you guess correct at " + numberofGuesses + " attempt");
                    gameOver = true;
                    
                    
                }
                else if(guess > randomNumber){
                Console.WriteLine("Nope! my number is smaller than that. try again ");
                 Console.WriteLine("you have  "  +   (6 -  numberofGuesses)  +  " attempt left ");
                }
                else if (guess < randomNumber){
                Console.WriteLine(" Nope my number is higher than that. try again");
                 Console.WriteLine("you have "  +  (6 - numberofGuesses)  +  " attempt left ");
                }
        
             }

            }
            else if(input == "MEDIUM")
            {
                 Console.WriteLine("In this leveel you have to guess between 1 to 20 and you have maximum of 4 attempt");
                 Console.WriteLine("type in your guess number! ");
                  while (gameOver == false)
                   {
                guess = Convert.ToInt32(Console.ReadLine());
                numberofGuesses++; 
               
                if(guess != randomNumber2 && numberofGuesses == 4)
                {
                    
                    Console.WriteLine("you couldn't figurre out the number in 4 attempt?!  YOU LOSE!! ");
                    gameOver = true;
                }
                else if(guess == randomNumber2)
                {
                    Console.WriteLine(" that's it YOU WIN!! you guess correct at " + numberofGuesses + " attempt ");
                    gameOver = true;
                    
                    
                }
                else if(guess > randomNumber2){
                Console.WriteLine(" Nope! my number is smaller than that. try again ");
                 Console.WriteLine("you have  "  +   (4 -  numberofGuesses)  +  "  attempt left ");
                }
                else if (guess < randomNumber2){
                Console.WriteLine("  Nope my number is higher than that. try again");
                 Console.WriteLine("you have "  +  (4 - numberofGuesses)  +  "  attempt left ");
                }
             } 
        

            }
             else if(input == "HARD")
            {
                 Console.WriteLine("In this leveel you have to guess between 1 to 50 and you have maximum of 3 life");
                 Console.WriteLine("type in your guess number! ");
                  while (gameOver == false)
                   {
                guess = Convert.ToInt32(Console.ReadLine());
                numberofGuesses++; 
               
                if(guess != randomNumber3 && numberofGuesses == 3)
                {
                    
                    Console.WriteLine(" you couldn't figurre out the number in 3 attempt?!  YOU LOSE!! ");
                    gameOver = true;
                }
                else if(guess == randomNumber3)
                {
                    Console.WriteLine("that's it YOU WIN!! you guess correct at " + numberofGuesses + " attempt");
                    gameOver = true;
                    
                    
                }
                else if(guess > randomNumber3){
                Console.WriteLine(" Nope! my number is smaller than that. try again ");
                 Console.WriteLine("you have  "  +   (3 -  numberofGuesses)  +  "  attempt left ");
                }
                else if (guess < randomNumber3){
                Console.WriteLine("  Nope my number is higher than that. try again ");
                 Console.WriteLine("you have "  +  (3 - numberofGuesses)  +  "  attempt left ");
                }
            }
           
      }
      Console.ReadLine();
           


        }
    }
}
