using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProductRegistration
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //можем только выбирать
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear(); //чистка
            comboBox1.Items.Add("Ферментированные"); //добавляем элементы
            comboBox1.Items.Add("Продукты сепарации");
            comboBox1.Items.Add("Высокотехнологичная МП");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 outputForm = new Form2();
            outputForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private IProduct GetCreateProduct(string name)
        {
            switch (name)
            {
                case ("Кефир"): return new Kefir();
                case ("Творог"): return new Curd();
                case ("Йогурт"): return new Yogurt();
                case ("Сметана"): return new SourСream();
                case ("Сливки"): return new Cream();
                case ("Мороженное"): return new IceCream();
                case ("Сухое молоко"): return new PowderedMilk();
                default: return null;
            }
        }
        private void CreateMessageBusOk(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, caption, buttons);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox2.Items.Clear();
                switch (comboBox1.SelectedItem)
                {
                    case ("Ферментированные"):
                        comboBox2.Items.Add("Кефир");
                        comboBox2.Items.Add("Творог");
                        comboBox2.Items.Add("Йогурт");
                        break;

                    case ("Продукты сепарации"):
                        comboBox2.Items.Add("Сметана");
                        comboBox2.Items.Add("Сливки");
                        break;

                    case ("Высокотехнологичная МП"):
                        comboBox2.Items.Add("Мороженное");
                        comboBox2.Items.Add("Сухое молоко");
                        break;

                    default:
                        comboBox2.Items.Clear();
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null) 
            {
                CreateMessageBusOk("Продукт не выбран", "Выбор продукта");
                return;
            }
            IProduct product = GetCreateProduct(comboBox2.SelectedItem.ToString());
            if (product == null)
            {
                CreateMessageBusOk("Ошибка при создании продукта", "Ошибка");
                return;
            }

            string name = product.GetProductName();
            if (checkBox1.Checked)
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("Введите новое название продукта",
                                                           "Ввод названия продукта",
                                                           name);
                product.SetProductName(name);
            }
            CreateMessageBusOk("Продукт создан!", "Создание продукта");
        }
    }
}
