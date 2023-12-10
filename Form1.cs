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
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList; //����� ������ ��������
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Clear(); //������
            comboBox1.Items.Add("����������������"); //��������� ��������
            comboBox1.Items.Add("�������� ���������");
            comboBox1.Items.Add("������������������� ��");
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
                case ("�����"): return new Kefir();
                case ("������"): return new Curd();
                case ("������"): return new Yogurt();
                case ("�������"): return new Sour�ream();
                case ("������"): return new Cream();
                case ("����������"): return new IceCream();
                case ("����� ������"): return new PowderedMilk();
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
                    case ("����������������"):
                        comboBox2.Items.Add("�����");
                        comboBox2.Items.Add("������");
                        comboBox2.Items.Add("������");
                        break;

                    case ("�������� ���������"):
                        comboBox2.Items.Add("�������");
                        comboBox2.Items.Add("������");
                        break;

                    case ("������������������� ��"):
                        comboBox2.Items.Add("����������");
                        comboBox2.Items.Add("����� ������");
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
                CreateMessageBusOk("������� �� ������", "����� ��������");
                return;
            }
            IProduct product = GetCreateProduct(comboBox2.SelectedItem.ToString());
            if (product == null)
            {
                CreateMessageBusOk("������ ��� �������� ��������", "������");
                return;
            }

            string name = product.GetProductName();
            if (checkBox1.Checked)
            {
                name = Microsoft.VisualBasic.Interaction.InputBox("������� ����� �������� ��������",
                                                           "���� �������� ��������",
                                                           name);
                product.SetProductName(name);
            }
            CreateMessageBusOk("������� ������!", "�������� ��������");
        }
    }
}
