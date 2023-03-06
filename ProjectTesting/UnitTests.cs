using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WSUniversalLib;

namespace ProjectTesting
{
    [TestClass]
    public class ProjectTesting
    {
        

        [TestMethod]
        public void Check_for_invalid_product_type()
        {
            //arrange
            int pType = 9;
            int mType = 1;
            int count = 15;
            float width = 20;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
        public void Check_for_invalid_material_type()
        {
            //arrange
            int pType = 3;
            int mType = 5;
            int count = 15;
            float width = 20;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
        public void Сheck_if_width_is_0_then_calculation_is_not_performed()
        {
            //Width = 0
            //arrange
            int pType = 3;
            int mType = 5;
            int count = 15;
            float width = 0;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
        public void Сheck_if_height_is_0_then_calculation_is_not_performed()
        {
            //arrange
            int pType = 3;
            int mType = 5;
            int count = 15;
            float width = 20;
            float length = 0;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
        public void Сheck_if_count_lower_than_zero()
        {
            //arrange
            int pType = 3;
            int mType = 5;
            int count = -3;
            float width = 20;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
        public void CalculatingWith_float_width_and_height_values()
        {
            //arrange
            int pType = 3;
            int mType = 1;
            int count = 15;
            float width = 17.33f;
            float length = 27.5f;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreNotEqual(metRes, -1);
        }

        [TestMethod]
        public void CalculatingWith_int_width_and_height_values()
        {
            //arrange
            int pType = 2;
            int mType = 2;
            int count = 5;
            float width = 10;
            float length = 10;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreNotEqual(metRes, -1);
        }

        [TestMethod]
        public void Сheck_if_material_type_lower_than_zero()
        {
            //arrange
            int pType = 3;
            int mType = -2;
            int count = 10;
            float width = 20;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
        public void Сheck_if_product_type_lower_than_zero()
        {
            //arrange
            int pType = -2;
            int mType = 5;
            int count = 10;
            float width = 20;
            float length = 45;
            //act
            int metRes = Calculation.GetQuantityForProduct(pType, mType, count, width, length);
            //assert
            Assert.AreEqual(metRes, -1);
        }

        [TestMethod]
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
            Assert.AreEqual(metRes, manRes);
        }
    }
}
