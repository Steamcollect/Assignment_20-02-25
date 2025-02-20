using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Health;
    public int Strength;
    public int Intelligence;

    public Weapon Weapon;

    public Buff Buff;

    public int Attack()
    {
        int weaponStrengh = Weapon != null ? Weapon.Strengh : 0;
        int buffStrengh = Buff != null ? Buff.Strengh : 0;

        UpdateBuff();

        return Strength + weaponStrengh + buffStrengh;
    }

    void UpdateBuff()
    {
        if(Buff != null)
        {
            Buff.DecreaseRemainingRound(1);
            if (!Buff.HaveTimeLeft()) Buff = null;
        }
    }

    public Character (string name, int health, int strength, int intelligence, Weapon weapon, Buff buff)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Intelligence = intelligence;
        Weapon = weapon;
        Buff = buff;
    }
}
