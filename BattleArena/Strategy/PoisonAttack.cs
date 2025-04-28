using BattleArena.Models;

namespace BattleArena.Strategy
{
    public class PoisonAttack : IAttackStrategy
    {
        public void Attack(ISoldier target)
        {
            target.TakeDamage(15);
        }
    }
}