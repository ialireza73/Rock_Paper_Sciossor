using System;

namespace Rock_Paper_Sciossor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play_again = true;
            string _result;
            int game_count = 0;
            int player_win = 0;
            int AI_win = 0;
            int Draw = 0;
            do
            {
                System.Console.WriteLine("choose between ROCK PAPER or SCIOSSORS");

                string playerChoose = Console.ReadLine().ToUpper();
                string[] options = { "ROCK", "PAPER", "SCIOSSORS" };
                string computerChoose = computerChoising(options);
                System.Console.WriteLine("Computer Choose :" + computerChoose);
                System.Console.WriteLine("your choose is :" + playerChoose);
                _result = result(playerChoose, computerChoose);
                game_count++;
                switch (_result)
                {
                    case "AI":
                        AI_win++;
                        break;
                    case "Player":
                        player_win++;
                        break;
                    case "Draw":
                        Draw++;
                        break;

                    default:
                        System.Console.WriteLine("something is wrong...");
                        break;
                }

                play_again = TryAgain(play_again);
            } while (play_again == true);
            if (play_again == false)
            {
                System.Console.WriteLine("thanks for play\n Good Bye!");
                System.Console.WriteLine("Game count: " + game_count);
                System.Console.WriteLine("player_win: " + player_win);
                System.Console.WriteLine("Coumputer_win: " + AI_win);
                System.Console.WriteLine("Draw: " + Draw);
            }

        }
        static string computerChoising(string[] patameter)
        {
            Random random = new Random();


            string choose = patameter[random.Next(0, 3)];


            return choose;
        }
        static String result(string player, string AI)
        {
            string _result = " ";
            if (AI == player)
            {
                System.Console.WriteLine("Draw :|");
                _result = "Draw";
            }
            else
            {
                switch (player)
                {
                    case "ROCK":

                        if (AI == "PAPER")
                        {
                            System.Console.WriteLine("you lose :(");
                            _result = "AI";
                        }
                        else if (AI == "SCIOSSORS")
                        {
                            System.Console.WriteLine("you win :)");
                            _result = "Player";
                        }
                        break;
                    case "PAPER":

                        if (AI == "ROCK")
                        {
                            System.Console.WriteLine("you win :)");
                            _result = "Player";
                        }
                        else if (AI == "SCIOSSORS")
                        {
                            System.Console.WriteLine("you lose :(");
                            _result = "AI";
                        }

                        break;
                    case "SCIOSSORS":
                        if (AI == "PAPER")
                        {
                            System.Console.WriteLine("you win :)");
                            _result = "Player";

                        }
                        else if (AI == "ROCK")
                        {
                            System.Console.WriteLine("you lose :(");
                            _result = "AI";

                        }

                        break;

                    default:
                        System.Console.WriteLine("your input is not vaid...choose between ROCK PAPER or SCIOSSORS");

                        break;

                }

            }
            return _result;
        }
        static bool TryAgain(bool playOrNot)
        {
            System.Console.WriteLine("Do you want to try again?(y/n)");
            string answer = Console.ReadLine();
            if (answer == "n")
            {

                playOrNot = false;

            }
            else if (answer == "y")
            {
                playOrNot = true;
            }
            else { System.Console.WriteLine("not a vaild answer..."); }
            return playOrNot;
        }


    }
}
