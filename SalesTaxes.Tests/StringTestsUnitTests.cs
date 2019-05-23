using NUnit.Framework;

namespace TrackMatic.SalesTaxes.Tests
{
    [TestFixture]
    public class StringTestsUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldCreateCart()
        {
            const string expected = "FooBar";
            const double expectedAmount = 1.00f;

            Cart a = new Cart(Type.Local, expected, expectedAmount);
            Assert.That(a.Name, Is.EqualTo(expected).IgnoreCase);
        }

        [Test]
        public void NameOfItemIsNull()
        {
            var cart = new Cart(Type.Local);
            Assert.That(cart.Name, Is.Null);
        }


    }
}