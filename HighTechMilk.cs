using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    abstract class HighTechMilk : IProduct
    {
        const IProduct.ProductTypes productType = IProduct.ProductTypes.HighTechMilk;
        static int highTechMilkProductCount = 0;
        public HighTechMilk()
        {
            highTechMilkProductCount++;
        }
        public abstract List<string> GetCookingMethod();
        public abstract string GetProductName();
        public abstract void SetProductName(string productName);
        public abstract string GetIndividualParameter();
        public abstract int GetPositionInAllProducts();
        public IProduct.ProductTypes GetProductType()
        {
            return productType;
        }
        public static int GetProductCount()
        {
            return highTechMilkProductCount;
        }
    }
}
