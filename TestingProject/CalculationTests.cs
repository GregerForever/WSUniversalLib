using WSUniversalLib;

namespace TestingProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalculatingWith_length45_width20_count15_productType3_materialType1()
        {
            //arrange
            int pType = 3;
            int mType = 1;
            int count = 15;
            float width = 20;
            float length = 45;
            //act
            int manRes = (int)Math.Ceiling(width * length * count * 8.43 * 1.003);
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.That(metRes, Is.EqualTo(manRes));
        }

        [Test]
        public void check_for_invalid_product_type()
        {
            //arrange
            int pType = 3;
            int mType = 1;
            int count = 15;
            float width = 20;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }
    }
}