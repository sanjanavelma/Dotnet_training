using System;
class Ge
{
    public static void Game()
    {
        Console.WriteLine("GAME BEGINS....");
        for(int i = 0; i<=10; i++)
        {
            if (i == 4)
            {
                Console.WriteLine($"Enemy{i} is invisible. Skipping enemy{4}");
                continue;
            }
            Console.WriteLine($"Player Killed Enemy{i}");
        }
        Console.WriteLine("Game Ends...");
    }
}