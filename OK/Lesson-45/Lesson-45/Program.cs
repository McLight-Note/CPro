using System;
using System.Collections.Generic;

namespace _45_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            
            players.Add(new Player("Chad"));
            players.Add(new Player("John"));
            players.Add(new Player("Brian"));

            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }

    class Player
    {
        public String username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    }
}