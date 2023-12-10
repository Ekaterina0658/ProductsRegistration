using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    class IceCream : HighTechMilk
    {
        List<string> cookingMethod = new List<string>();
        private string productName = "Мороженное";
        private const string typeOfFinishedProduct = "Твёрдое или мягкое состояние, лёд";
        int positionInAllProducts = 0;
        public IceCream() : base()
        {
            IProduct.AddProduct(this);
            positionInAllProducts = IProduct.GetAllProducts().Count - 1;
            cookingMethod.Add("1. Смешать коровье молоко, сливки, сахар и ароматизаторы");
            cookingMethod.Add("2. Варить с периодическим помешиванием");
            cookingMethod.Add("3. Фильтрация полученной смеси");
            cookingMethod.Add("4. Пастеризация продукта");
            cookingMethod.Add("5. Охлаждение продукта");
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
