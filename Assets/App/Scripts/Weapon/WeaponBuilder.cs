using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBuilder
{
    string Name;
    int Strengh;

    public WeaponBuilder WithName(string name)
    {
        Name = name;
        return this;
    }
    public WeaponBuilder WithStrengh(int strengh)
    {
        Strengh = strengh;
        return this;
    }

    public Weapon Build()
    {
        return new Weapon(Name, Strengh);
    }

    public static implicit operator Weapon(WeaponBuilder builder)
    {
        return builder.Build();
    }
}
