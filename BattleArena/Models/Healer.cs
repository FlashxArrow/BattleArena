using BattleArena.Strategy;

namespace BattleArena.Models
{
    public class Healer : ISoldier
    {
        public string Name { get; private set; }
        public int Health { get; set; } = 110;
        private IAttackStrategy attackStrategy;

        public Healer(string name)
        {
            Name = name;
            attackStrategy = new NormalAttack();  
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
