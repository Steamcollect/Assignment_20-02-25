using NUnit.Framework;

public class BuffStatisticsTest
{
    [Test]
    public void Should_Set_Buff_Strengh()
    {
        Buff buff = A.Buff.WithStrengh(10);

        Assert.AreEqual(10, buff.Strengh);
    }
    
    [Test]
    public void Should_Set_Buff_RemainingRound()
    {
        Buff buff = A.Buff.WithRemainingRound(10);

        Assert.AreEqual(10, buff.RemainingRound);
    }
}