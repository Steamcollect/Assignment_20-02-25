using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CharacterStatisticsTest
{
    [Test]
    public void Should_Set_Character_Name()
    {
        Character character = A.Character.WithName("Bob");

        Assert.AreEqual("Bob", character.Name);
    }
    
    [Test]
    public void Should_Set_Character_Health()
    {
        Character character = A.Character.WithHealth(10);

        Assert.AreEqual(10, character.Health);
    }
    
    [Test]
    public void Should_Set_Character_Strengh()
    {
        Character character = A.Character.WithStrengh(10);

        Assert.AreEqual(10, character.Strength);
    }
    
    [Test]
    public void Should_Set_Character_Intelligence()
    {
        Character character = A.Character.WithIntelligence(10);

        Assert.AreEqual(10, character.Intelligence);
    }

    [Test]
    public void Should_Set_Character_Weapon()
    {
        Weapon weapon = A.Weapon.WithName("Sword").WithStrengh(10);
        Character character = A.Character.WithWeapon(weapon);

        Assert.AreEqual(weapon, character.Weapon);
    }
}
