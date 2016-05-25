namespace BowlingGame_Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using BowlingGame.libs;

    [TestClass]
    public class Game_Test
    {
        
        [TestMethod]
        public void HasNeedetProperties_Test()
        {
            var game = new Game();
            int expectedScore = 4;
            game.AddRoll(expectedScore);
            int result = game.Frames[0].PinsRolled[0];
            Assert.AreEqual(expectedScore, result);
        }
    }
}
