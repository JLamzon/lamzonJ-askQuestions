﻿//Jessie Lamzon
//10/17/22
//GitHubChallenge - Redo mini Challenges
//Ask Questions - add data validation and play again




Console.Clear();

string playAgain = "yes";
//DateTime time;

while (playAgain != "no")
{
Console.WriteLine("What is your name?");
string myName = Console.ReadLine();


Console.WriteLine("What time did you wake up? Enter as 00:00 and in 24HR format");
string time = Console.ReadLine();
DateTime realTime;

if (DateTime.TryParse(time, out realTime))
{
Console.WriteLine("Your name is " + myName + " and you woke up at " + time + ".");
}
else
{
    Console.WriteLine("Please enter correct format");
}

Console.WriteLine("Would you like to play again? yes/no");
playAgain = Console.ReadLine();

}

Console.WriteLine("Thanks for playing!");