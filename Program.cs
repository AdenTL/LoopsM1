using template_csharp_loops;

bool keepThinking = true;
while (keepThinking)
{
    Console.Clear();
    Console.WriteLine("LOOPING EXERCISES\n");
    Console.WriteLine("Which exercise would you like to run?");
    Console.WriteLine("1. Print Numbers in Reverse Order");
    Console.WriteLine("2. Reverse Counting");
    Console.WriteLine("3. Print the Square of Even Numbers");
    Console.WriteLine("4. Guess the Magic Number");
    Console.WriteLine("5. ZingBot Invasion");
    Console.WriteLine("Press Q to quit");

    string userChoice = Console.ReadLine().ToLower();

    switch (userChoice)
    {
        case "1":
            Exercises.NumbersInReverse();
            break;
        case "2":
            Exercises.ReverseCounting();
            break;
        case "3":
            Exercises.SquareOfEvenNumbers();
            break;
        case "4":
            Exercises.GuessMagicNumber();
            break;
        case "5":
            // ZingBot bot = new ZingBot();
            // bot.Start();
            break;
        case "q":
            keepThinking = false;
            Console.WriteLine("Good bye!");
            break;
        default:
            break;
    }
}