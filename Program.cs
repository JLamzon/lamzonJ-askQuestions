//Jessie Lamzon
//10/17/22
//GitHubChallenge - Redo mini Challenges
//Ask Questions - add data validation and play again
// Peer Review: Elizar Garcia, code works well. 
// It has the while loop and tryparse. Easy to use 
// and follow. Asking for a specific time format was unique 
// definetly liked it and it would loop until you gave it what 
// it was asking for. Very well done.




Console.Clear();

string playAgain = "yes";
//DateTime time;

while (playAgain != "no")
{
    Console.WriteLine("What is your name?");
    string myName = Console.ReadLine();

    while (true)
    {
        Console.WriteLine("What time did you wake up? Enter as 00:00 AM/PM format");
        string time = Console.ReadLine();

        //checks and alerts user to use the correct format
        DateTime realTime;
        if (DateTime.TryParse(time, out realTime))
        {
            Console.WriteLine($"Your name is {myName} and you woke up at {time}.");
            break;
        }
        else
        {
            Console.WriteLine("Please enter correct format");
        }
    }

    //play Again loop 
    Console.WriteLine("Press any key to play again or type no...");
    playAgain = Console.ReadLine();
}

Console.WriteLine("Thanks for playing!");