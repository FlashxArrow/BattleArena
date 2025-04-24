using BattleArena.Models;

namespace BattleArena.Strategy
{
    public class NormalAttack : IAttackStrategy
    {
        public void Attack(ISoldier target)
        {
            target.TakeDamage(10);
        }
    }
}