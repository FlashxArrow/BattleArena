using BattleArena.Models;

namespace BattleArena.Strategy
{
    public class ArrowAttack : IAttackStrategy
    {
        public void Attack(ISoldier target)
        {
            target.TakeDamage(20);
        }
    }
}