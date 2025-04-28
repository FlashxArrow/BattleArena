namespace BattleArena.Models
{
    public interface ISoldier
    {
        string Name { get; }
        int Health { get; set; }
        void Attack(ISoldier target);
        void TakeDamage(int damage);
    }
}