public class Characterbuilder
{
    string Name;
    int Health;
    int Strengh;
    int Intelligence;

    Weapon Weapon;
    Buff Buff;

    public Characterbuilder WithName(string name)
    {
        Name = name;
        return this;
    }

    public Characterbuilder WithHealth(int health)
    {
        Health = health;
        return this;
    }

    public Characterbuilder WithStrengh(int strengh)
    {
        Strengh = strengh;
        return this;
    }
    
    public Characterbuilder WithIntelligence(int intelligence)
    {
        Intelligence = intelligence;
        return this;
    }

    public Characterbuilder WithWeapon(Weapon weapon)
    {
        Weapon = weapon;
        return this;
    }

    public Characterbuilder WithBuff(Buff buff)
    {
        Buff = buff;
        return this;
    }

    public Character Build()
    {
        return new Character(Name, Health, Strengh, Intelligence, Weapon, Buff);
    }

    public static implicit operator Character(Characterbuilder builder)
    {
        return builder.Build();
    }
}