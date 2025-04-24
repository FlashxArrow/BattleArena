using BattleArena.Strategy;

namespace BattleArena.Models
{
    public class Warrior : ISoldier
    {
        public string Name { get; private set; }
        public int Health { get; set; } = 100;

        private IAttackStrategy attackStrategy;

        public Warrior(string name)
        {
            Name = name;
            attackStrategy = new HeavyAttack();  
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
        }
    }
}