[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void PrimeFactorsOf60()
    {
        var expected = new List<int> { 2, 2, 3, 5 };
        var actual = MyMath.GetPrimeFactors(60);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PrimeFactorsOf13()
    {
        var expected = new List<int> { 13 };
        var actual = MyMath.GetPrimeFactors(13);
        CollectionAssert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void PrimeFactorsOf1()
    {
        var expected = new List<int> { };
        var actual = MyMath.GetPrimeFactors(1);
        CollectionAssert.AreEqual(expected, actual);
    }
}
