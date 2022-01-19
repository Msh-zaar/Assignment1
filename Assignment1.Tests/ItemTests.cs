using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System;
using Xunit;

namespace Assignment1.Tests
{
    public class ItemTests
    {
        // --- BASE FUNCTIONALITY TESTS ---

        [Fact]
        public void Check_WarriorCanWieldAxeOfTooHighItemLevel_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 2,
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            // Act
            Action act = () => testWarrior.EquipWeapon(testAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);

        }
        [Fact]
        public void Check_WarriorCanEquipPlateArmourOfTooHighLevel_ShouldThrowInvalidArmourException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 2,
                ItemSlot = "Body",
                ArmTyp = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };
            // Act
            Action act = () => testWarrior.EquipArmour(testPlateBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void Check_WarriorCanWieldWrongWeaponType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testBow = new Weapon()
            {
                ItemName = "Common Bow",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Bow,
                BaseDamage = 12,
                AttackSpeed = 0.8
            };
            // Act
            Action act = () => testWarrior.EquipWeapon(testBow);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        [Fact]
        public void Check_WarriorCanEquipWrongArmourType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Armour testClothHead = new Armour()
            {
                ItemName = "Common Cloth Head Armour",
                ReqLevel = 2,
                ItemSlot = "Head",
                ArmTyp = Armour.ArmourType.Cloth,
                Attributes = new PrimaryAttributes(0, 0, 5)
            };
            // Act
            Action act = () => testWarrior.EquipArmour(testClothHead);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        [Fact]
        public void CheckToSeeIfMessageIsReturnedOnSuccesfulEquipWeapon_ShouldReturnString()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            // Act
            string expectedMessage = "New weapon equipped!";
            // Assert
            Assert.Equal(testWarrior.EquipWeapon(testAxe), expectedMessage);
        }
        [Fact]
        public void CheckToSeeIfMessageIsReturnedOnSuccesfulEquipArmour_ShouldReturnString()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 1,
                ItemSlot = "Body",
                ArmTyp = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };
            // Act
            string expectedMessage = "New armour equipped!";
            // Assert
            Assert.Equal(testWarrior.EquipArmour(testPlateBody), expectedMessage);
        }
        [Fact]
        public void CheckWarriorDamageAtLevel1_ShouldReturn1point01()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            // Act
            double expectedDamage = 1 * (1 + (5 / 100));
            // Assert
            Assert.Equal(testWarrior.DealDamage(), expectedDamage);
        }
        [Fact]
        public void CheckWarriorDamageAtLevel1WithWeapon_ShouldReturnAround7point7()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            testWarrior.EquipWeapon(testAxe);
            // Act
            double expectedDamageWithWeapon = (7 * 1.1) * (1 + (5 / 100));
            // Assert
            Assert.Equal(testWarrior.DealDamage(), expectedDamageWithWeapon);
        }
        [Fact]
        public void CheckWarriorDamageAtLevel1WithWeaponAndArmour_ShouldReturnAround7point7()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                WepTyp = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            testWarrior.EquipWeapon(testAxe);

            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 1,
                ItemSlot = "Body",
                ArmTyp = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };
            testWarrior.EquipArmour(testPlateBody);
            // Act
            double expectedDamageWithWeaponAndArmour = (7 * 1.1) * (1 + ((5 + 1) / 100));
            // Assert
            Assert.Equal(testWarrior.DealDamage(), expectedDamageWithWeaponAndArmour);
        }
    }
}