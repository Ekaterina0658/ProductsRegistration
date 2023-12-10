using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    abstract class Separation : IProduct
    {
        const IProduct.ProductTypes productType = IProduct.ProductTypes.Separation;
        static int separationProductCount = 0;
        public Separation()
        {
            separationProductCount++;
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
            return separationProductCount;
        }
    }
}
