using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class CharacterStatisticsTest
{
    #region Statistics
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
    #endregion

    [Test]
    public void Should_Set_Character_Attack()
    {
        Character character = A.Character.WithStrengh(10);

        character.Weapon = null;
        character.Buff = null;
        // Je suis obligé de set Weapon & Buff a NULL,
        // Jsp pourquoi mais elle est gardé en mémoire avec les tests precedents et ça fait sauter ce test
        // Si tu veux tester sans le WithWeapon, ça marchera si tu lance le test seul, mais pas si tu les run tous

        Assert.AreEqual(10, character.Attack());
    }

    #region Weapon
    [Test]
    public void Should_Set_Character_Weapon()
    {
        Weapon weapon = A.Weapon.WithName("Sword").WithStrengh(10);
        Character character = A.Character.WithWeapon(weapon);

        Assert.AreEqual(weapon, character.Weapon);
    }

    [Test]
    public void Should_Set_Character_Attack_With_Weapon()
    {
        Weapon weapon = A.Weapon.WithName("Sword").WithStrengh(10);

        Character character = A.Character.WithStrengh(10).WithWeapon(weapon);
        
        character.Buff = null;

        Assert.AreEqual(20, character.Attack());
    }
    #endregion

    #region Buff
    [Test]
    public void Should_Set_Character_Buff()
    {
        Buff buff = A.Buff.WithStrengh(10).WithRemainingRound(10);
        Character character = A.Character.WithBuff(buff);

        Assert.AreEqual(buff, character.Buff);
    }

    [Test]
    public void Should_Set_Character_Attack_With_Buff()
    {
        Buff buff = A.Buff.WithStrengh(10);
        Character character = A.Character.WithStrengh(10).WithBuff(buff);

        character.Weapon = null;

        Assert.AreEqual(20, character.Attack());
    }
    
    [Test]
    public void Should_Set_Character_Attack_With_Buff_And_Remaining_Time()
    {
        Buff buff = A.Buff.WithStrengh(10).WithRemainingRound(1);
        Character character = A.Character.WithStrengh(10).WithBuff(buff);

        character.Weapon = null;

        for (int i = 0; i < 2; i++)
        {
            if(i == 0) Assert.AreEqual(20, character.Attack());
            else Assert.AreEqual(10, character.Attack());
        }
    }
    #endregion

    #region Weapon_&_Buff
    [Test]
    public void Should_Set_Character_Attack_With_Weapon_And_Buff()
    {
        Weapon weapon = A.Weapon.WithStrengh(10);
        Buff buff = A.Buff.WithStrengh(10);
        Character character = A.Character.WithStrengh(10).WithWeapon(weapon).WithBuff(buff);

        Assert.AreEqual(30, character.Attack());
    }
    #endregion
}