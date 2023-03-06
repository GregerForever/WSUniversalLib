using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSUniversalLib
{
    public class Calculation
    {
        public static int GetQuantityForProduct(int productType, int materialType, int count, float width, float length)
        {
            double prodCoef, matCoef;

            if (count <= 0)
            {
                return -1;
            }
            if (width <= 0 || length <= 0)
            {
                return -1;
            }

            switch (productType)
            {
                case 1:
                    prodCoef = 1.1;
                    break;
                case 2:
                    prodCoef = 2.5;
                    break;
                case 3:
                    prodCoef = 8.43;
                    break;
                default:
                    return -1;
            }

            switch (materialType)
            {
                case 1:
                    matCoef = 1.003;
                    break;
                case 2:
                    matCoef = 1.0012;
                    break;
                default:
                    return -1;
            }

            return (int)Math.Ceiling(width * length * count * prodCoef * matCoef); 
        }
    }
}
