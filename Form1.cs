using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace assignment2
{
    public partial class Form1 : Form
    {
      
        List<string> contactNo = new List<string>();
        List<string> address = new List<string>();
        List<string> order = new List<string>();
        List<string> customerName = new List<string>();
        List<int> quantity = new List<int>();
        List<int> totalPrice= new List<int>();

        int i = 0;
        int price = 0;
        int g;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
           
            if (String.IsNullOrEmpty(comboBox1.Text) || String.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Please enter order");
                comboBox1.Focus();
                return;
               
            }
            if (String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Please enter quantity");
                textBox4.Focus();
                return;

            }
           
           
            if(contactNo.Contains(textBox2.Text))
            {
                MessageBox.Show("Number already exists!");
                textBox2.Focus();
                return;

            }

             

            customerName.Add(textBox1.Text);
            contactNo.Add(textBox2.Text);
            address.Add(textBox3.Text);
            order.Add( comboBox1.Text);
           

            try
            {
                quantity.Add( Convert.ToInt32(textBox4.Text));
            }
            catch(System.FormatException)
            {
                quantity.Add(0);
            }
               

            switch (order[i])
            {
                case "Black": price = 120;
                    break;
                case "Cold": price = 100;
                    break;
                case "Hot": price = 90;
                    break;
                case "Regular": price = 80;
                    break;
            }


             
                int sum= price * quantity[i];
            totalPrice.Add( sum);

          

            textBox1.Focus();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.SelectedIndex = -1;
            textBox4.Clear();
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        
            for (int j = 0; j < i; j++)
            {
              
                richTextBox1.AppendText(" \n");
                richTextBox1.AppendText("              " + (j+ 1) + ". Purchase Recipt      ");
                richTextBox1.AppendText("===============================");
                richTextBox1.AppendText("\n     Customer Name:      " + customerName[j]);
                richTextBox1.AppendText("\n     Phone No.:              " + contactNo[j]);
                richTextBox1.AppendText("\n     Address:                  " + address[j]);
                richTextBox1.AppendText("\n     Order:                      " + order[j]);
                richTextBox1.AppendText("\n     Quantity:                 " + quantity[j]);
                richTextBox1.AppendText("\n===============================");
            richTextBox1.AppendText("\n     total :                      " + totalPrice[j] + " BDT");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
