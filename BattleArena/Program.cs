using BattleArena.Factory;
using System;

namespace BattleArena
{
    class Program
    {
        static void Main(string[] args)
        {
            var arena = new BattleArenaManager();

            arena.AddSoldier(SoldierFactory.CreateSoldier("warrior", "Hercules"));
            arena.AddSoldier(SoldierFactory.CreateSoldier("archer", "Odysseus"));
            arena.AddSoldier(SoldierFactory.CreateSoldier("healer", "Aesculapius"));

            var winner = arena.StartBattle();
            Console.WriteLine($"🏆Câștigătorul este: {winner.Name}");
        }
    }
}