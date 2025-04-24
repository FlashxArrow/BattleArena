using Xunit;
using BattleArena.Models;

namespace BattleArena.Tests
{
    public class SoldierTests
    {
        [Fact]
        public void Warrior_Attack_ReducesTargetHealth()
        {
            // Arrange
            var attacker = new Warrior("TestWarrior");
            var target = new Warrior("Target");

            // Act
            attacker.Attack(target);

            // Assert
            Assert.Equal(80, target.Health); // damage 20
        }

        [Fact]
        public void SoldierWithHealing_Heal_IncreasesHealth()
        {
            // Arrange
            var healer = new Healer("Healer");

            // Act
            healer.Heal();

            // Assert
            Assert.Equal(115, healer.Health); // Health increased by 5
        }

        [Fact]
        public void BattleArenaManager_BattleResultsInWinner()
        {
            // Arrange
            var battleArena = new BattleArenaManager();
            var warrior1 = new Warrior("Warrior1");
            var warrior2 = new Archer("Archer1");

            battleArena.AddSoldier(warrior1);
            battleArena.AddSoldier(warrior2);

            // Act
            var winner = battleArena.StartBattle();

            // Assert
            Assert.NotNull(winner); // There should be a winner
        }
    }
}