//Jessie Lamzon
//10/17/22
//GitHubChallenge - Redo mini Challenges
//Ask Questions - add data validation and play again




Console.Clear();

string playAgain = "yes";


while (playAgain != "no")
{
Console.WriteLine("What is your name?");
string myName = Console.ReadLine();


Console.WriteLine("What time did you wake up?");
string awake = Console.ReadLine();

Console.WriteLine("Your name is " + myName + " and you woke up at " + awake + ".");

Console.WriteLine("Would you like to play again? yes/no");
playAgain = Console.ReadLine();

}

Console.WriteLine("Thanks for playing!");