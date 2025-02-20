using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CharacterStatisticsTest
{
    [Test]
    public void Should_Set_Character_Name()
    {
        Character character = A.character.WithName("Bob");

        Assert.AreEqual("Bob", character.Name);
    }
    
    [Test]
    public void Should_Set_Character_Health()
    {
        Character character = A.character.WithHealth(10);

        Assert.AreEqual(10, character.Health);
    }
    
    [Test]
    public void Should_Set_Character_Strengh()
    {
        Character character = A.character.WithStrengh(10);

        Assert.AreEqual(10, character.Strength);
    }
    
    [Test]
    public void Should_Set_Character_Intelligence()
    {
        Character character = A.character.WithIntelligence(10);

        Assert.AreEqual(10, character.Intelligence);
    }
}
