using Assignment1.Item;
using System;
using Xunit;

namespace Assignment1.Tests
{
    public class ItemTests
    {
        // --- BASE FUNCTIONALITY TESTS ---

        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void Check_WarriorCanUseAxeOfCorrectItemLevel_ShouldEquip()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                ItemSlot = "Weapon",
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            // Act
            
            // Assert
            
        }
        /// <summary>
        /// 
        /// </summary>
        [Fact]
        public void Check()
        {
            // Arrange

            // Act

            // Assert

        }
    }
}