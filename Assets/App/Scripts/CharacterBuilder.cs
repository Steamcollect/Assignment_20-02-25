public class Characterbuilder
{
    string Name;
    int Health;
    int Strengh;
    int Intelligence;

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

    public Character Build()
    {
        return new Character(Name, Health, Strengh, Intelligence);
    }

    public static implicit operator Character(Characterbuilder characterbuilder)
    {
        return characterbuilder.Build();
    }
}