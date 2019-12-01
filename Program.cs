using System;

namespace ChooseYourOwnAdventure
{
  class Program
  {
      static void Main(string[] args)
    {
      /* THE MYSTERIOUS NOISE */

      // Start by asking for the user's name:
      Console.Write("What is your name?: ");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello, {name}! Welcome to our story.");
        
        Console.Write("It begins on a cold rainy night. You're sitting in your room and hear a             noise coming from down the hall. Do you go investigate? ");
        Console.Write( "Type yes or no ");
        string noiseChoice = Console.ReadLine();
        string bigWord = noiseChoice.ToUpper();

        
        if (noiseChoice == "no")
        {
          Console.WriteLine("Not much of an adventure if we don't leave our room! '\n' THE END. ");
        }
          else if (noiseChoice == "yes")
        {
            Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.'\n' You walk towards it. Do you open it or knock?");
        }
            Console.Write( "Type OPEN or KNOCK: ");
        string doorChoice = Console.ReadLine();
        string UpDoorChoice =         doorChoice.ToUpper();
        
        if (doorChoice == "knock")
        {
          Console.Write("A voice behind the door speaks. It says, Answer this riddle: Poor people have it. Rich people need it. If you eat it you die. What is it?");
        }
        else if (doorChoice == "open")
        {
          Console.Write("The door is locked! See if one of your three keys will open it.");
        }
        Console.Write("Type your answer: ");
        string riddleAnswer = Console.ReadLine();
        if (riddleAnswer == "nothing")
        {
          Console.Write("The door opens and NOTHING is there. You turn off the light and run back to your room and lock the door. \n THE END. ");
        }
        else 
        {
          Console.Write("You answered incorrectly. The door doesn't open.\nTHE END.");
        }
        Console.Write("Enter a number (1-3):");
        string keyChoice = Console.ReadLine();
        string upKeyChoice = keyChoice.ToUpper();
        
        switch (keyChoice)
        {
          case "1":
            Console.WriteLine("You choose the first key. Lucky choice! \n The door opens and NOTHING is there. Strange...\n THE END.");
            break;
            
          case "2":
            Console.WriteLine("You choose the second key. The door doesn't open. \n THE END. ");
            break;
            
          case "3":
              Console.WriteLine("You choose the third key. The door doesn't open.\n THE END. ");
            break;
            
            default:
            Console.WriteLine("You didn't choose non of the first three option keys.");
              break;
            
            }
    }
  }
}



