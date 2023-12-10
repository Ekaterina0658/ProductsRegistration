using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    abstract class Fermented : IProduct
    {
        const IProduct.ProductTypes productType = IProduct.ProductTypes.Fermented;
        static int fermentedProductCount = 0;
        public Fermented()
        {
            fermentedProductCount++;
        }
        public abstract List<string> GetCookingMethod();
        public abstract string GetProductName();
        public abstract void SetProductName(string productName);
        public abstract int GetPositionInAllProducts();
        public abstract string GetIndividualParameter();
        public IProduct.ProductTypes GetProductType()
        {
            return productType;
        }
        public static int GetProductCount()
        {
            return fermentedProductCount;
        }
    }
}
