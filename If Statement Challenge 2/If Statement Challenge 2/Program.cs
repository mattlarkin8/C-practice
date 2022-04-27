using System;

namespace If_Statement_Challenge_2
{
    class Program
    {
        static string highscorePlayer = "Other Guy";
        static int highscore = 12;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter player name:");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter your score:");
            string scoreInput = Console.ReadLine();
            int score = int.Parse(scoreInput);
            checkHighscore(score, playerName);
        }

        public static void checkHighscore(int score, string playerName)
        {
            
            
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;
                Console.WriteLine($"New highscore is {score}\nNew highscore holder is {playerName}");
            }
         else
            {
                Console.WriteLine($"The old highscore of {highscore} could not be broken and is still held by {highscorePlayer}");
            }
        
        }
    }
}
