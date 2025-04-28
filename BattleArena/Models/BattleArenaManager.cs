using System;
using System.Collections.Generic;
using BattleArena.Models;

namespace BattleArena
{
    public class BattleArenaManager
    {
        private List<ISoldier> soldiers;
        private Random random;

        public BattleArenaManager()
        {
            soldiers = new List<ISoldier>();
            random = new Random();
        }

        public void AddSoldier(ISoldier soldier)
        {
            soldiers.Add(soldier);
        }

        public ISoldier StartBattle()
        {
            while (soldiers.Count > 1)
            {
                var attacker = soldiers[random.Next(soldiers.Count)];
                var target = soldiers[random.Next(soldiers.Count)];

                while (attacker == target)
                {
                    target = soldiers[random.Next(soldiers.Count)];
                }

                attacker.Attack(target);

                Console.WriteLine($"\n {attacker.Name} ⚔️ {target.Name}. Remaining HP of {target.Name}: {target.Health}\n");

                if (target.Health <= 0)
                {
                    soldiers.Remove(target);
                    Console.WriteLine($"{target.Name} a fost învins!\n");
                }
            }

            return soldiers[0];  // Soldatul rămas în viață este câștigătorul
        }
    }
}