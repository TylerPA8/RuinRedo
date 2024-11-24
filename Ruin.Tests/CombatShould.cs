namespace Ruin.Tests
{
    [TestClass]
    public class CombatShould
    {
        [TestMethod]
        public void LoadsEmptyArray()
        {
            // Arrange 
            Array<Creature> expectedArray = [];

            // Act 

            // Assert 
            expectedArray.Should().BeEmpty();
        }
    }
}