using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinOfFunc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Listdelegate = new List<MyFuncDelegate>();
            Listdelegate.Add(Program.SinF);
            Listdelegate.Add(Program.CosF);
            Listdelegate.Add(Program.F1divX2);
            Listdelegate.Add(Program.F1divSin);
            Listdelegate.Add(Program.F1divCos);
        }
        List<MyFuncDelegate> Listdelegate;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double minF;
            Program.SaveFunc(Listdelegate[FunBox.SelectedIndex], "data.bin", (double)start.Value, (double)end.Value);
            double[] dArr = Program.Load("data.bin", out minF);
            min.Text = minF.ToString("0.00000");
            textBox.AppendText("Значения функции:\n");
            foreach (double item in dArr)
            {
                textBox.AppendText($"{item,8:0.000}");
            }
            textBox.AppendText("\n");
        }
    }
}
