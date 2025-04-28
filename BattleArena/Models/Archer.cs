using BattleArena.Strategy;
using System;

namespace BattleArena.Models
{
    public class Archer : ISoldier 
    {
        public string Name { get; private set; }
        public int Health { get; set; } = 120;  

        private IAttackStrategy attackStrategy;

        private static Random random = new Random();  // Obiect de random pentru a alege strategia aleatoriu

        // Constructorul Archer va alege aleatoriu între NormalAttack și HeavyAttack
        public Archer(string name)
        {
            Name = name;

            // Alege aleatoriu între NormalAttack și HeavyAttack
            attackStrategy = random.Next(2) == 0 ? new NormalAttack() : new ArrowAttack();  // 0 sau 1 pentru a alege între cele 2 strategii
        }

       
        public void Attack(ISoldier target)
        {
            attackStrategy.Attack(target);
        }

        
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
