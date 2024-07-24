// Mini Games:

internal class Program
{
    private static void Main(string[] args)
    {
       
        //Number  Guessing Game:

        Random random = new Random();    // Generating Random Numbers
        int rand = random.Next(1, 50);

        // Declearing Variables:
        bool playAgain = true;
        int num;
        int Guesses;
        string response;

        while (playAgain)
        {
            num = 0;
            Guesses = 0;
            response = "";
            rand = random.Next(1, 50);

            while (num != rand)
            {
                Console.Write("\nEnter Any Number Between 1 - 50: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Num:" + num);

                if (num < rand)
                {
                    Console.WriteLine("You are Guessing Lower Number!");
                }
                else if (num > rand)
                {
                    Console.WriteLine("You are Guessing Higher Number!");
                }
                Guesses++;    // Increasing no of guesses by 1 each time 

         }
            Console.WriteLine("\nCongralutations You have Won The Game");
            Console.WriteLine("Guesses: " + Guesses);



        // Play Again or Not?
        Console.WriteLine("\nWould you like to play again (Y/N): ");
        response = Console.ReadLine();
        response = response.ToUpper();


        if (response == "Y")
        {
            playAgain = true;
        }
        else
        {
            playAgain = false;
        }
    }
    Console.WriteLine("Thanks for Playing!");



        // Sissor , Paper, Rock:

Random random1 = new Random();
        bool playagain = true;
        string Player;
        string Computer;
        string answer;

        while (playagain)
        {
            Player = "";
            Computer = "";
            answer = "";

            while (Player != "ROCK" && Player != "PAPER" && Player != "SCISSORS")
            {
                Console.Write("\n\t\tEnter SCISSORS, PAPPER or ROCK: ");
                Player = Console.ReadLine();
                Player = Player.ToUpper();
            }
            
            // generating random (scissors,paper,rock for computer)
            switch (random1.Next(1,4)) {

            case 1:
                    Computer = "ROCK";
                    break;

            case 2:
                    Computer = "PAPER";
                    break;

            case 3:
                    Computer = "SCISSORS";
                    break;

        }
            Console.WriteLine("Player: " + Player);
            Console.WriteLine("Computer: " + Computer);


            // player matches with computer or not?
            switch (Player)
            {

                case "ROCK":
                   if (Computer == "SCISSORS")
                    {
                        Console.WriteLine("\nIt's a draw!");
                    }
                    else if (Computer == "PAPER")
                    {
                        Console.WriteLine("\nYou Loose!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou Win!");
                    }
                    break;


                case "PAPER":
                    if (Computer == "ROCK")
                    {
                        Console.WriteLine("\nYou Win!");
                    }
                    else if (Computer == "PAPER")
                    {
                        Console.WriteLine("\nIt's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("\nYou Loose!");
                    }

                    break;

                case "SCISSORS":
                    if (Computer == "ROCK")
                    {
                        Console.WriteLine("\nYou Loose!");
                    }
                    else if (Computer == "PAPER")
                    {
                        Console.WriteLine("\nYou Win ");
                    }
                    else
                    {
                        Console.WriteLine("\nIt's a draw!");
                    }
                    break;

            }

         
            // Play Again or Not?
            Console.WriteLine("\nWould you like to play again (Y/N): ");
            answer = Console.ReadLine();
            answer = answer.ToUpper();


            if (answer == "Y")
            {
                playagain = true;
            }
            else
            {
                playagain = false;
            }
        }
        Console.WriteLine("Thanks for Playing!");


        Console.ReadKey();
    }
}

