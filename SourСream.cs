using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    class SourСream : Separation
    {
        List<string> cookingMethod = new List<string>();
        private string productName = "Сметана";
        private const string percentOfFatContent = "10-40%";
        int positionInAllProducts = 0;
        public SourСream() : base()
        {
            IProduct.AddProduct(this);
            positionInAllProducts = IProduct.GetAllProducts().Count - 1;
            cookingMethod.Add("1. Отбор 32% сливок");
            cookingMethod.Add("2. Молочнокислое брожение");
        }
        public override string GetProductName()
        {
            return productName;
        }
        public override void SetProductName(string productName)
        {
            this.productName = productName;
        }
        public override List<string> GetCookingMethod()
        {
            return cookingMethod;
        }
        public override string GetIndividualParameter()
        {
            return percentOfFatContent;
        }
        public override int GetPositionInAllProducts()
        {
            return positionInAllProducts;
        }
        public int GetSeparationProductCount()
        {
            return GetProductCount();
        }
    }
}
