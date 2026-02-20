using ForTask;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FindBiggestTest()
        {
            float[] floatMassive = new float[] {1, 2, 1 , 3, 2};
            int length = floatMassive.Length;
            var countFloat = Logic.FindBiggest(length, floatMassive);
            float[] compareMassive = new float[] {2,3};
            Assert.That(compareMassive, Is.EqualTo(countFloat));
        }
    }
}
