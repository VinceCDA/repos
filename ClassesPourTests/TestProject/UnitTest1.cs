using ClassesATester;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        [TestCase(-1,2,1)]
        [TestCase(0, 3, 3)]
        [TestCase(1, 2, 3)]
        public void TestCalculatrice(int a, int b,int expected)
        {
            Calculatrice calculatrice = new();

            Assert.AreEqual(expected, calculatrice.Additionner(a, b));
        }
        [Test]
        [TestCase(null,false)]
        [TestCase("", false)]
        [TestCase("01234", false)]
        [TestCase("aa251", false)]
        [TestCase("01234567890123", false)]
        [TestCase("82823393200015", true)]
        public void TestSiret(string siret,bool expected)
        {
            Assert.AreEqual(expected, SIRET.VerifierSIRET(siret));
        }

    }
}