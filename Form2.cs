using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductRegistration
{
    public partial class Form2 : Form
    {
        private void WriteLineInConsole(string line)
        {
            textBox1.Text += line + Environment.NewLine;
        }
        public Form2()
        {
            InitializeComponent();
            if (IProduct.GetAllProducts().Count == 0)
                WriteLineInConsole("Продуктов нет");
            else
            {
                foreach (var item in IProduct.GetAllProducts())
                {
                    WriteLineInConsole("Номер продукта в общем списке: " + item.GetPositionInAllProducts());
                    WriteLineInConsole("Название продукта: " + item.GetProductName());
                    WriteLineInConsole("Тип продукта: " + item.GetProductType());
                    switch (item.GetProductType())
                    {
                        case IProduct.ProductTypes.Fermented:
                            WriteLineInConsole("Тип закваски: " + item.GetIndividualParameter());
                            break;

                        case IProduct.ProductTypes.Separation:
                            WriteLineInConsole("Процент жирности: " + item.GetIndividualParameter());
                            break;

                        case IProduct.ProductTypes.HighTechMilk:
                            WriteLineInConsole("Состояние готового продукта: " + item.GetIndividualParameter());
                            break;

                        default: break;
                    }
                    WriteLineInConsole("Способ приготовления: ");
                    foreach (var str in item.GetCookingMethod())
                        WriteLineInConsole(str);
                    WriteLineInConsole("");
                }
                WriteLineInConsole("Итого продуктов: Ферментированные: " + Fermented.GetProductCount() +
                                   " Сепарации: " + Separation.GetProductCount() +
                                   " Высокотехнологичных МП: " + HighTechMilk.GetProductCount());
            }  
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
