using ForTask;
namespace TestProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SimpleTest()
    {
        double[] doubleMassive = new double[] { 1.3, 2.35, 1.83, 3.13, 2.2 };
        int length = doubleMassive.Length;
        var countdouble = Logic.CreateArrayNeighbors(length, doubleMassive);
        double[] compareMassive = new double[] { 2.35, 3.13 };
        Assert.That(compareMassive, Is.EqualTo(countdouble));
    }
    [Test]
    public void NullCompareTest()
    {
        double[] doubleMassive = new double[] { };
        int length = doubleMassive.Length;
        var countdouble = Logic.CreateArrayNeighbors(length, doubleMassive);
        double[] compareMassive = new double[] { };
        Assert.That(compareMassive, Is.EqualTo(countdouble));
    }
    [Test]
    public void AllSameTest()
    {
        double[] doubleMassive = new double[] { 1, 1, 1, 1, 1 };
        int length = doubleMassive.Length;
        var countdouble = Logic.CreateArrayNeighbors(length, doubleMassive);
        double[] compareMassive = new double[] { };
        Assert.That(compareMassive, Is.EqualTo(countdouble));
    }
    [Test]
    public void NegativeTest()
    {
        double[] doubleMassive = new double[] { -1, 2, -2 };
        int length = doubleMassive.Length;
        var countdouble = Logic.CreateArrayNeighbors(length, doubleMassive);
        double[] compareMassive = new double[] { 2 };
        Assert.That(compareMassive, Is.EqualTo(countdouble));
    }
}