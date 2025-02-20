using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public string Name;
    public int Health;
    public int Strength;
    public int Intelligence;

    public Character (string name, int health, int strength, int intelligence)
    {
        Name = name;
        Health = health;
        Strength = strength;
        Intelligence = intelligence;
    }
}
