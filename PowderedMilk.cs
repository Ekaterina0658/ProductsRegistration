using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    class PowderedMilk : HighTechMilk
    {
        List<string> cookingMethod = new List<string>();
        private string productName = "Сухое молоко";
        private const string typeOfFinishedProduct = "Сухое состояние, порошок";
        int positionInAllProducts = 0;
        public PowderedMilk() : base()
        {
            IProduct.AddProduct(this);
            positionInAllProducts = IProduct.GetAllProducts().Count - 1;
            cookingMethod.Add("1. Пастеризация молока");
            cookingMethod.Add("2. Высушивание пастеризованного молока");
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
            return typeOfFinishedProduct;
        }
        public override int GetPositionInAllProducts()
        {
            return positionInAllProducts;
        }
        public int GetHighTechMilkProductCount()
        {
            return GetProductCount();
        }
    }
}
