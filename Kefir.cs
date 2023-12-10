using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    class Kefir : Fermented
    {
        List<string> cookingMethod = new List<string>();
        private string productName = "Кефир";
        private const string typeOfStarterCulture = "Кефирный гриб";
        int positionInAllProducts = 0;
        public Kefir() : base()
        {
            IProduct.AddProduct(this);
            positionInAllProducts = IProduct.GetAllProducts().Count;
            cookingMethod.Add("1. Взять молоко");
            cookingMethod.Add("2. Добавить кефирные грибки");
            cookingMethod.Add("3. В зависимости от нужного количества спирта держать от 1 до нескольких дней");
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
            return typeOfStarterCulture;
        }
        public override int GetPositionInAllProducts()
        {
            return positionInAllProducts;
        }
        public int GetFermentedProductCount()
        {
            return GetProductCount();
        }
    }
}
