using BattleArena.Models;
using System;

namespace BattleArena.Factory
{
    public static class SoldierFactory
    {
        public static ISoldier CreateSoldier(string type, string name)
        {
            return type.ToLower() switch
            {
                "warrior" => new Warrior(name),
                "archer" => new Archer(name),  
                "healer" => new Healer(name),
                _ => throw new ArgumentException($"Unknown soldier type: {type}")
            };
        }
    }
}
