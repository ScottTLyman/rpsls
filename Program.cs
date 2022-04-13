// See https://aka.ms/new-console-template for more information
string greeting = "Would you like to play a Game? (y/n)";
for (int i = 0; i < greeting.Length; i++)
{
  Console.Write(greeting[i]);
  Thread.Sleep(50);
}
char answer = Console.ReadKey().KeyChar;
if (answer == 'y')
{
  Console.WriteLine("\n\nChallenge Accepted!");
}

bool gameLoop = true;
int uPoints = 0;
int cPoints = 0;
while (gameLoop)
{
  Console.WriteLine("\nChoose your Weapon:");
  Console.WriteLine("\n1. Rock");
  Console.WriteLine("2. Paper");
  Console.WriteLine("3. Scissors");
  Console.WriteLine("4. Lizard");
  Console.WriteLine("5. Spock");

  string uChoice = Console.ReadLine();
  Random randChoice = new Random();
  int cpuChoice = randChoice.Next(1, 6);

  switch (cpuChoice)
  {
    case 1:
      if (uChoice == "1")
      {
        Console.WriteLine("You chose Rock");
        Console.WriteLine("I chose Rock");
        Console.WriteLine("It is a Tie!");
      }
      else if (uChoice == "2")
      {
        Console.WriteLine("You chose Paper");
        Console.WriteLine("I chose Rock");
        Console.WriteLine("Your Paper covers my Rock!");
        uPoints++;
      }
      else if (uChoice == "3")
      {
        Console.WriteLine("You chose Scissors");
        Console.WriteLine("I chose Rock");
        Console.WriteLine("My Rock smashed your Scissors!");
        cPoints++;
      }
      else if (uChoice == "4")
      {
        Console.WriteLine("You chose Lizard");
        Console.WriteLine("I chose Rock");
        Console.WriteLine("My Rock crushes your Lizard!");
        cPoints++;
      }
      else if (uChoice == "5")
      {
        Console.WriteLine("You chose Spock");
        Console.WriteLine("I chose Rock");
        Console.WriteLine("Spock vaporizes my Rock!");
        uPoints++;
      }
      break;
    case 2:
      if (uChoice == "1")
      {
        Console.WriteLine("You chose Rock");
        Console.WriteLine("I chose Paper");
        Console.WriteLine("My Paper covers your Rock!");
        cPoints++;
      }
      else if (uChoice == "2")
      {
        Console.WriteLine("You chose Paper");
        Console.WriteLine("I chose Paper");
        Console.WriteLine("It is a Tie!");
      }
      else if (uChoice == "3")
      {
        Console.WriteLine("You chose Scissors");
        Console.WriteLine("I chose Paper");
        Console.WriteLine("Your Scissors cut my Paper!");
        uPoints++;
      }
      else if (uChoice == "4")
      {
        Console.WriteLine("You chose Lizard");
        Console.WriteLine("I chose Paper");
        Console.WriteLine("Your Lizard eats my Paper!");
        uPoints++;
      }
      else if (uChoice == "5")
      {
        Console.WriteLine("You chose Spock");
        Console.WriteLine("I chose Paper");
        Console.WriteLine("My Paper disproves Spock!");
        cPoints++;
      }
      break;
    case 3:
      if (uChoice == "1")
      {
        Console.WriteLine("You chose Rock");
        Console.WriteLine("I chose Scissors");
        Console.WriteLine("Your Rock smashes my Scissors!");
        uPoints++;
      }
      else if (uChoice == "2")
      {
        Console.WriteLine("You chose Paper");
        Console.WriteLine("I chose Scissors");
        Console.WriteLine("My Scissors cut your Paper!");
        cPoints++;
      }
      else if (uChoice == "3")
      {
        Console.WriteLine("You chose Scissors");
        Console.WriteLine("I chose Scissors");
        Console.WriteLine("It is a Tie!");
      }
      else if (uChoice == "4")
      {
        Console.WriteLine("You chose Lizard");
        Console.WriteLine("I chose Scissors");
        Console.WriteLine("My Scissors decapitate your Lizard!");
        cPoints++;
      }
      else if (uChoice == "5")
      {
        Console.WriteLine("You chose Spock");
        Console.WriteLine("I chose Scissors");
        Console.WriteLine("Spock smashes my Scissors!");
        uPoints++;
      }
      break;
    case 4:
      if (uChoice == "1")
      {
        Console.WriteLine("You chose Rock");
        Console.WriteLine("I chose Lizard");
        Console.WriteLine("Your Rock crushes my Lizard!");
        uPoints++;
      }
      else if (uChoice == "2")
      {
        Console.WriteLine("You chose Paper");
        Console.WriteLine("I chose Lizard");
        Console.WriteLine("My Lizard eats your Paper!");
        cPoints++;
      }
      else if (uChoice == "3")
      {
        Console.WriteLine("You chose Scissors");
        Console.WriteLine("I chose Lizard");
        Console.WriteLine("Your Scissors decapitate my Lizard!");
        uPoints++;
      }
      else if (uChoice == "4")
      {
        Console.WriteLine("You chose Lizard");
        Console.WriteLine("I chose Lizard");
        Console.WriteLine("It is a Tie!");
      }
      else if (uChoice == "5")
      {
        Console.WriteLine("You chose Spock");
        Console.WriteLine("I chose Lizard");
        Console.WriteLine("My Lizard poisons Spock!");
        cPoints++;
      }
      break;
    case 5:
      if (uChoice == "1")
      {
        Console.WriteLine("You chose Rock");
        Console.WriteLine("I chose Spock");
        Console.WriteLine("Spock vaporizes your Rock!");
        cPoints++;
      }
      else if (uChoice == "2")
      {
        Console.WriteLine("You chose Paper");
        Console.WriteLine("I chose Spock");
        Console.WriteLine("Your Paper disproves Spock!");
        uPoints++;
      }
      else if (uChoice == "3")
      {
        Console.WriteLine("You chose Scissors");
        Console.WriteLine("I chose Spock");
        Console.WriteLine("Spock smashes your Scissors!");
        cPoints++;
      }
      else if (uChoice == "4")
      {
        Console.WriteLine("You chose Lizard");
        Console.WriteLine("I chose Spock");
        Console.WriteLine("Your Lizard poisons Spock!");
        uPoints++;
      }
      else if (uChoice == "5")
      {
        Console.WriteLine("You chose Spock");
        Console.WriteLine("I chose Spock");
      }
      Console.WriteLine("Two instances of Spock cannot exist in the same period, you have broken reality!!");
      break;
  }
  Console.WriteLine("Would you like to play Again? (y/n)");
  Thread.Sleep(50);
  string playAgain = Console.ReadLine();
  if (playAgain == "N" || playAgain == "n" || playAgain == "no")
  {
    gameLoop = false;
    Console.WriteLine($"You have earned {uPoints} points - I have earned {cPoints} points");
  }

}
