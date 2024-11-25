using FluentAssertions;
using RuinRedo;
namespace Ruin.Tests
{
    [TestClass]
    public class CombatShould
    {
        [TestMethod]
        public void LoadsEmptyInitiative()
        {
            // Arrange 
            Dictionary<Creature, int> Initiative= new Dictionary<Creature, int> ();


            // Act 
            var sut = new Combat(); 
            

            // Assert 
            sut.initiativeTracker.Should().BeEquivalentTo(Initiative);
            sut.initiativeTracker.Should().BeOfType<Dictionary<Creature, int>>();
        }
    }
}