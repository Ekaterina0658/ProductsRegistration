using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    class Cream : Separation
    {
        List<string> cookingMethod = new List<string>();
        private string productName = "Сливки";
        private const string percentOfFatContent = "10%, 20%, 35%";
        int positionInAllProducts = 0;
        public Cream() : base()
        {
            IProduct.AddProduct(this);
            positionInAllProducts = IProduct.GetAllProducts().Count - 1;
            cookingMethod.Add("1. Сливки появляются спустя несколько часов на свежем молоке");
            cookingMethod.Add("2. Снять верхний слой");
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
