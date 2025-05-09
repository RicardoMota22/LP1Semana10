using System;
using System.Collections.Generic;

namespace EqualPlayer
{
    
    public class Program
    {
        private static void Main(string[] args)
        {
            HashSet<Player> setOfPlayers = new HashSet<Player>();

            setOfPlayers.Add(new Player(Player.PlayerClass.Tank, "Ana"));
            setOfPlayers.Add(new Player(Player.PlayerClass.Slayer, "Paulo"));
            setOfPlayers.Add(new Player(Player.PlayerClass.Tank, "Ana"));

            foreach (Player i in setOfPlayers)
                Console.Write(i + "is a " +i.PClass);
            Console.WriteLine();
        }
        
        
    }
}
