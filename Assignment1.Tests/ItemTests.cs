using Assignment1.Attributes;
using Assignment1.Item;
using Assignment1.Item.ItemExceptions;
using System;
using Xunit;

namespace Assignment1.Tests
{
    public class ItemTests
    {
        // --- EQUIPPING WEAPONS AND ARMOUR ---

        /// <summary>
        /// Asserts that a level 1 warrior can't wield a level 2 axe.
        /// </summary>
        [Fact]
        public void EquipWeapon_IfAxeIsTooHighLevel_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 2,
                Type = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            // Act
            Action act = () => testWarrior.EquipWeapon(testAxe);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);

        }
        /// <summary>
        /// Asserts that a level 1 warrior can't equip level 2 armour.
        /// </summary>
        [Fact]
        public void EquipArmour_IfArmourIsTooHighLevel_ShouldThrowInvalidArmourException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 2,
                ItemSlot = "Body",
                Type = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };
            // Act
            Action act = () => testWarrior.EquipArmour(testPlateBody);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        /// <summary>
        /// Asserts that a warrior can't wield a bow.
        /// </summary>
        [Fact]
        public void EquipWeapon_IfWeaponIsWrongType_ShouldThrowInvalidWeaponException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testBow = new Weapon()
            {
                ItemName = "Common Bow",
                ReqLevel = 1,
                Type = Weapon.WeaponType.Bow,
                BaseDamage = 12,
                AttackSpeed = 0.8
            };
            // Act
            Action act = () => testWarrior.EquipWeapon(testBow);
            // Assert
            Assert.Throws<InvalidWeaponException>(act);
        }
        /// <summary>
        /// Asserts that a warrior can't wield cloth armour.
        /// </summary>
        [Fact]
        public void EquipArmour_IfArmourIsWrongType_ShouldThrowInvalidArmourException()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Armour testClothHead = new Armour()
            {
                ItemName = "Common Cloth Head Armour",
                ReqLevel = 2,
                ItemSlot = "Head",
                Type = Armour.ArmourType.Cloth,
                Attributes = new PrimaryAttributes(0, 0, 5)
            };
            // Act
            Action act = () => testWarrior.EquipArmour(testClothHead);
            // Assert
            Assert.Throws<InvalidArmourException>(act);
        }
        /// <summary>
        /// Asserts that a message is displayed upon wielding a new weapon.
        /// </summary>
        [Fact]
        public void EquipWeapon_UponSuccesfullEquip_ShouldReturnMessage()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                Type = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            // Act
            string expectedMessage = "New weapon equipped!";
            // Assert
            Assert.Equal(testWarrior.EquipWeapon(testAxe), expectedMessage);
        }
        /// <summary>
        /// Asserts that a message is displayed upon equipping a new piece of armour.
        /// </summary>
        [Fact]
        public void EquipArmour_UponSuccesfullEquip_ShouldReturnMessage()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 1,
                ItemSlot = "Body",
                Type = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };
            // Act
            string expectedMessage = "New armour equipped!";
            // Assert
            Assert.Equal(testWarrior.EquipArmour(testPlateBody), expectedMessage);
        }

        // --- DEALING DAMAGE ---
        // DealDamage() --- floating point maths did not work without casting the divident to a double 
        /// <summary>
        /// Asserts that a level 1 warrior deals 1.05 barehanded damage 
        /// </summary>
        [Fact]
        public void DealDamage_WarriorDamageAtLevel1_ShouldReturn1point05()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            // Act
            double expectedDamage = 1 * (1 + ((double)5 / 100)); //1.05 
            double actualDamage = testWarrior.DealDamage();
            // Assert
            Assert.Equal(expectedDamage, actualDamage);
        }
        /// <summary>
        /// Asserts that a warrior at level 1, wielding the testAxe deals 8.8085 damage
        /// </summary>
        [Fact]
        public void DealDamage_WarriorDamageAtLevel1WithWeapon_ShouldReturnAround8point085()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                Type = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            testWarrior.EquipWeapon(testAxe);
            // Act
            double expectedDamageWithWeapon = (7 * 1.1) * (1 + ((double)5 / 100)); //8.085
            double actualDamage = testWarrior.DealDamage();
            // Assert
            Assert.Equal(expectedDamageWithWeapon, actualDamage);
        }
        /// <summary>
        /// Asserts that a warrior at level 1, wielding the testAxe, equipped with the testPlateBody deals 8.162 damage
        /// </summary>
        [Fact]
        public void DealDamage_WarriorDamageAtLevel1WithWeaponAndArmour_ShouldReturnAround8point162()
        {
            // Arrange
            Warrior testWarrior = new Warrior();
            Weapon testAxe = new Weapon()
            {
                ItemName = "Common Axe",
                ReqLevel = 1,
                Type = Weapon.WeaponType.Axe,
                BaseDamage = 7,
                AttackSpeed = 1.1
            };
            testWarrior.EquipWeapon(testAxe);

            Armour testPlateBody = new Armour()
            {
                ItemName = "Common Plate Body Armour",
                ReqLevel = 1,
                ItemSlot = "Body",
                Type = Armour.ArmourType.Plate,
                Attributes = new PrimaryAttributes(1, 0, 0)
            };
            testWarrior.EquipArmour(testPlateBody);
            // Act
            double expectedDamageWithWeaponAndArmour = (7 * 1.1) * (1 + ((double)(5 + 1) / 100)); //8.162
            double actualDamage = testWarrior.DealDamage();
            // Assert
            Assert.Equal(expectedDamageWithWeaponAndArmour, actualDamage);
        }
    }
}