using BattleArena.Models;

namespace BattleArena.Strategy
{
    public interface IAttackStrategy
    {
        void Attack(ISoldier target);
    }
}