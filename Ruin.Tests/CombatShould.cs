using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;
using RuinRedo;

namespace Ruin.Tests
{
    [TestClass]
    public class CombatShould
    {
        [TestMethod]
        public void LoadsEmptyInitiativeArray()
        {
            // Arrange 
            Creature[] expectedArray = [];

            // Act 
            var sut = new Combat(); 
            

            // Assert 
            sut.initiativeTracker.Should().BeEmpty();
        }
    }
}