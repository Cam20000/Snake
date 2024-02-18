using System;
using System.Xml.Linq;
using Game;
using main;
namespace SnakeTests
{
    [TestClass]
    public class SnakeTests
    {
        [TestMethod]
        public void DifficultyCheck()
        {
            int expected = SnakeGame.difficulty;
            int actual = main.Program.difficulty;
            Assert.AreEqual(actual, expected);
        }
    }
}