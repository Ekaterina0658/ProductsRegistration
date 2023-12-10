using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRegistration
{
    interface IProduct
    {
        private static List<IProduct> products = new List<IProduct>();
        public enum ProductTypes{
            Fermented,
            Separation,
            HighTechMilk
        }
        string GetProductName();
        void SetProductName(string productName);
        List<string> GetCookingMethod();
        int GetPositionInAllProducts();
        string GetIndividualParameter();
        public abstract ProductTypes GetProductType();
        public static List<IProduct> GetAllProducts()
        {
            return products;
        }
        protected static void AddProduct(IProduct item)
        {
            products.Add(item);
        }
    }
}
