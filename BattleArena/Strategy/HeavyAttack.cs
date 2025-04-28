using BattleArena.Models;

namespace BattleArena.Strategy
{
    public class HeavyAttack : IAttackStrategy
    {
        public void Attack(ISoldier target)
        {
            target.TakeDamage(25);
        }
    }
}