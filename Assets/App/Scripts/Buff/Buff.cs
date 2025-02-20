public class Buff
{
    public int Strengh;
    public int RemainingRound;

    public void DecreaseRemainingRound(int count)
    {
        RemainingRound -= count;
    }

    public bool HaveTimeLeft()
    {
        return RemainingRound > 0;
    }

    public Buff(int strengh, int remainingRound)
    {
        Strengh = strengh;
        RemainingRound = remainingRound;
    }
}