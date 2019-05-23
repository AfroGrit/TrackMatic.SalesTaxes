using NUnit.Framework;
namespace TrackMatic.SalesTaxes.Tests

{
    [TestFixture]
    public class CartCollectionUnitTests
    {
        [Test]
        public void CartCollectionUnitTest()
        {
            var carty = new Cart(Type.Import);
            Assert.That(carty.Type, Is.Unique);

        }
    }
}
