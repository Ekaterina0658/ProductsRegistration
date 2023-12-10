using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    class Curd : Fermented
    {
        List<string> cookingMethod = new List<string>();
        private string productName = "Творог";
        private const string typeOfStarterCulture = "Сычужный фермент";
        int positionInAllProducts = 0;
        public Curd() : base()
        {
            IProduct.AddProduct(this);
            positionInAllProducts = IProduct.GetAllProducts().Count - 1;
            cookingMethod.Add("1. Взять молоко");
            cookingMethod.Add("2. Добавить сычужный фермент");
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
