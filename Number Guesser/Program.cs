using System;


namespace Number_Guesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //App information function calling
            AppInfo();
            //User Greeting function calling
            GreetUser();

            while (true)
            {
                //Creating a new random object
                Random random = new Random();
                //init correct no and giving random parameter to 1-10
                int correctNumber = random.Next(1, 10);

                //Guess No
                int guessNo = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guessNo != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //If its not a number input
                    if (!int.TryParse(input, out guessNo))
                    {
                        ColorMessage(ConsoleColor.Magenta, "Please use an actual number");
                        //continue
                        continue;
                    }
                    //cast to int and out in guessNo
                    guessNo = Convert.ToInt32(input);

                    if (guessNo != correctNumber)
                    {
                        // error message 
                        ColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                //success message print
                ColorMessage(ConsoleColor.Yellow, "Hurrah!!!! Correct Answer..");

                //If play Again
                Console.WriteLine("Play Again? [Y or N]");
                string answer = Console.ReadLine().ToUpper();
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    Console.WriteLine("Exit, See You Again!!!");
                    return;
                }
                else
                {
                    return;
                }
            }
        }
        static void AppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Anosh Khan";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Printing Header(app info)
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            //Reset text color
            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"Hello {userName}, let's play a game ...");
            Console.ResetColor();
        }
        static void ColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
