public class BuffBuilder
{
    int Strengh;
    int RemainingRound;

    public BuffBuilder WithStrengh(int strengh)
    {
        Strengh = strengh;
        return this;
    }

    public BuffBuilder WithRemainingRound(int remainingRound)
    {
        RemainingRound = remainingRound;
        return this;
    }

    public Buff Build()
    {
        return new Buff(Strengh, RemainingRound);
    }

    public static implicit operator Buff(BuffBuilder builder)
    {
        return builder.Build();
    }
}