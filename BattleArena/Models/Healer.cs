using BattleArena.Strategy;
using System;

namespace BattleArena.Models
{
    public class Healer : ISoldier
    {
        public string Name { get; private set; }
        public int Health { get; set; } = 110;

        private IAttackStrategy attackStrategy;

        private static Random random = new Random();

        public Healer(string name)
        {
            Name = name;
            attackStrategy = random.Next(2) == 0 ? new NormalAttack() : new PoisonAttack();
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        public void Attack(ISoldier target)
        {
            attackStrategy.Attack(target);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            this.Heal(); // doar daca este lovit isi activeaza heal-ul
        }

        public void Heal() // Poate primi mai multe potiuni
        {
            Health += 5; // Heal
        }
    }
}
