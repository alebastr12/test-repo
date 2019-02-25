/*
 2.	Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
 Бастраков Александр
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AextboxAndNumeric
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int t;
            if (int.TryParse((sender as TextBox).Text, out t))
            {
                numericUpDown1.Value = t;
            }
            else numericUpDown1.Value = 0;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text=(sender as NumericUpDown).Value.ToString();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //textBox1.Text = (sender as NumericUpDown).Value.ToString();
        }
    }
}
