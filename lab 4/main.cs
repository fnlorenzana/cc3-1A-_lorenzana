using System;
public class Launcher {
    public static void Main(string[]args) {
        Console.WriteLine("\nWelcome to the Amazing Guess!");
    
        while (true){
        Console.WriteLine("\n1.Start");
        Console.WriteLine("2.Exit");
        Console.Write("\nEnter your choice(1-2): ");
        string response=Console.ReadLine(). ToLower();
        
        if (response == "1"){
            GuessTheNumber.Play();
        }
        else if (response == "2"){
            Console.WriteLine("\nThank you for playing the game!");
            Environment.Exit(0);
            
        }
        else{
            Console.WriteLine("Error. Please try again!");
        }
        }
    }
}


public class GuessTheNumber {
  public static void Play(){
      
      Random rnd = new Random();
      int number = rnd.Next(1, 101);
      int guess;
      int difference;
      int Limiter=10;
      int NumberOfGuess=0;
      int GuessLimit=10;
      
      Console.WriteLine("\nInstructions:");
      Console.WriteLine("Guess the number within the range of 1-100");
      Console.WriteLine("You have 10 number of guess");
      
      while (NumberOfGuess<GuessLimit){
          
          Console.Write("\nEnter a number from 1 - 100: ");
          guess = Convert.ToInt32(Console.ReadLine());
          NumberOfGuess++;
          Limiter--;
          
          difference = Math.Abs(number - guess);
          
          if (difference==0){
              Console.WriteLine("\nCONGRATULATIONS!!");
              break;
          }          
          else if (difference <= 5){
              Console.WriteLine("You are close to perfect. ");
              Console.WriteLine("You have " + (Limiter)+ "  guess left");
          }
          else if (difference <=10){
              Console.WriteLine("Warmer");
              Console.WriteLine("You have " + (Limiter)+ "  guess left");
          }
          else if (difference <=30){
              Console.WriteLine("Ohhh, that's a bit cold");
              Console.WriteLine("You have " + (Limiter)+ "  guess left");
          }
          else if (difference <=50){
              Console.WriteLine("You are freezing!");
              Console.WriteLine("You have " + (Limiter)+ "  guess left");
          }
          else if (difference<100){
              Console.WriteLine("You are dead");
              break;
          }
          else{
              Console.WriteLine("Invalid Input. Please Try Again");
              Console.WriteLine("You have " + (Limiter)+ "  guess left");
              
          }
          
          if(NumberOfGuess==GuessLimit){
              Console.WriteLine("\nYou are out of Guess. Please Try Again!! ");
             
            }
        }
         Console.WriteLine("Do you want to play again(y/n)" );
         string PlayAgainResponse=Console.ReadLine();
         
         if (PlayAgainResponse=="y"){
             Launcher.Main(null);
             
         }
         
         else if(PlayAgainResponse=="n"){
             Console.WriteLine("\nThank you for playing!");
             Environment.Exit(0);
         }
  }
  }
         
         