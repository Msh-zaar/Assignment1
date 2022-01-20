using System;
using Xunit;

namespace Assignment1.Tests
{
    public class ClassesTests
    {
        // --- BASE FUNCTIONALITY TESTS ---
        //Method/Behaviour_Params_Expected

        /// <summary>
        /// Checks to see if a newly created character (Mage) is level 1
        /// </summary>
        [Fact]
        public void Construct_CharacterLevelAtCreation_ShouldReturn1()
        {
            // Arrange
            Mage testMage = new Mage();
            // Act
            int expectedLevel = 1;
            // Assert
            Assert.Equal(testMage.Level, expectedLevel);
        }
        /// <summary>
        /// Checks to see if a level 1 character (Mage) turns into level 2 after running the LevelUp-method
        /// </summary>
        [Fact]
        public void LevelUp_LevelAfterOneGainedLevel_ShouldReturn2()
        {
            // Arrange
            Mage testMage = new Mage();
            // Act
            int expectedLevel = 2;
            testMage.LevelUp();
            // Assert
            Assert.Equal(testMage.Level, expectedLevel);
        }
        // --- LEVEL ONE TESTS ---

        /// <summary>
        /// Checks to see that the base attributes of a level 1 mage is 1 strength, 1 decterity and 8 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelOneForMage_ShouldReturn118()
        {
            // Arrange
            Mage testMage = new Mage();
            int[] expectedAttributes = new int[] {1, 1, 8}; // Default values of a mages attributes
            // Act
            int[] actualAttributes = testMage.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        /// <summary>
        /// Checks to see that the base attributes of a level 1 ranger is 1 strength, 7 decterity and 1 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelOneForRanger_ShouldReturn171()
        {
            // Arrange
            Ranger testRanger = new Ranger();
            int[] expectedAttributes = new int[] { 1, 7, 1 }; // Default values of a rangers attributes
            // Act
            int[] actualAttributes = testRanger.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        /// <summary>
        /// Checks to see that the base attributes of a level 1 rogue is 2 strength, 6 decterity and 1 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelOneForRogue_ShouldReturn261()
        {
            // Arrange
            Rogue testRogue = new Rogue();
            int[] expectedAttributes = new int[] { 2, 6, 1 }; // Default values of a rogues attributes
            // Act
            int[] actualAttributes = testRogue.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        /// <summary>
        /// Checks to see that the base attributes of a level 1 warrior is 5 strength, 2 decterity and 1 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelOneForWarrior_ShouldReturn521()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            int[] expectedAttributes = new int[] { 5, 2, 1 }; // Default values of a warriors attributes
            // Act
            int[] actualAttributes = testWarrior.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        // --- LEVEL 2 TESTS ---

        /// <summary>
        /// Checks to see that the base attributes of a level 2 mage is 2 strength, 2 decterity and 13 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelTwoForMage_ShouldReturn2213()
        {
            // Arrange
            Mage testMage = new Mage();
            int[] expectedAttributes = new int[] { 2, 2, 13 };
            // Act
            testMage.LevelUp();
            int[] actualAttributes = testMage.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        /// <summary>
        /// Checks to see that the base attributes of a level 2 ranger is 2 strength, 12 decterity and 2 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelTwoForRanger_ShouldReturn2122()
        {
            // Arrange
            Ranger testRanger = new Ranger();
            int[] expectedAttributes = new int[] { 2, 12, 2 }; // Default values of a rangers attributes
            // Act
            testRanger.LevelUp();
            int[] actualAttributes = testRanger.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        /// <summary>
        /// Checks to see that the base attributes of a level 2 rogue is 3 strength, 10 decterity and 2 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelTwoForRogue_ShouldReturn3102()
        {
            // Arrange
            Rogue testRogue = new Rogue();
            int[] expectedAttributes = new int[] { 3, 10, 2 }; // Default values of a rogues attributes
            // Act
            testRogue.LevelUp();
            int[] actualAttributes = testRogue.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
        /// <summary>
        /// Checks to see that the base attributes of a level 2 warrior is 8 strength, 4 decterity and 2 intelligence.
        /// </summary>
        [Fact]
        public void GetAttributes_AttributesAtLevelTwoForWarrior_ShouldReturn3102()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            int[] expectedAttributes = new int[] { 8, 4, 2 }; // Default values of a warriors attributes
            // Act
            testWarrior.LevelUp();
            int[] actualAttributes = testWarrior.GetAttributes();
            // Assert
            Assert.Equal(expectedAttributes, actualAttributes);
        }
    }
}
