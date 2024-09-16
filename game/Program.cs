namespace game
{
    internal class Program
    {
        /*Invaders from outer space have arrived and are abducting 
         * humans using tractor beams. Players must crack the codeword 
         * to stop the abduction!*/
        static void Main(string[] _)
        {
            Console.CancelKeyPress += new ConsoleCancelEventHandler(OnExit);
            Game.Intro();

            bool StayOn;
            do
            {
                Random rand = new();
                Game g = new(rand.Next(820));

                while (!g.DidWin() && !g.DidLose())
                {
                    g.Display();
                    g.Start();
                }

                g.Display();

            exit:

                if (Console.ForegroundColor != ConsoleColor.DarkBlue)
                    Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.Write(" PLAY AGAIN? (y/n): ");

                Console.ForegroundColor = ConsoleColor.DarkRed;

                string answer = Console.ReadLine() ?? "possible null assignment";

                if (!string.IsNullOrEmpty(answer))
                {
                    if (answer == answer.ToUpper())
                        answer = answer.ToLower();

                    if (answer == "n")
                        StayOn = false;
                    else if (answer == "y")
                        StayOn = true;
                    else
                    {
                        g.Display();
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(" need Y or N |");
                        goto exit;
                    }
                }
                else
                {
                    g.Display();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(" NEED y OR n |");
                    goto exit;
                }

            } while (StayOn);

            Console.ResetColor();
        }

        protected static void OnExit(object? sender, ConsoleCancelEventArgs k)
        {
            k.Cancel = true;
            FinalTasks();
        }

        private static void FinalTasks()
        {
            Console.ResetColor();
            Console.Write("exiting app...");
            Environment.Exit(0);
        }
    }
}