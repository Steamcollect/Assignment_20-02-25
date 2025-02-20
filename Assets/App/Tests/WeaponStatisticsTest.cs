using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class WeaponStatisticsTest
{
    [Test]
    public void Should_Set_Weapon_Name()
    {
        Weapon weapon = A.Weapon.WithName("Sword");

        Assert.AreEqual("Sword", weapon.Name);
    }
    
    [Test]
    public void Should_Set_Weapon_Strengh()
    {
        Weapon weapon = A.Weapon.WithStrengh(10);

        Assert.AreEqual(10, weapon.Strengh);
    }
}
