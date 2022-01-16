using System;
using Xunit;

namespace Assignment1.Tests
{
    public class CharacterTests
    {
        [Fact]
        public void Check_CharacterLevelAtCreation_ShouldReturn1()
        {
            // Arrange
            Mage testMage = new Mage();
            // Act
            int levelOne = 1;
            // Assert
            Assert.Equal(testMage.Level, levelOne);
        }

        [Fact]
        public void Check_LevelUpOnLevelOneCharacter_ShouldReturn2()
        {
            // Arrange
            Mage testMage = new Mage();
            // Act
            int levelTwo = 2;
            testMage.LevelUp();
            // Assert
            Assert.Equal(testMage.Level, levelTwo);
        }
    }
}
