using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNum
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int num = 0;
        int step = 0;
        public Form1()
        {
            InitializeComponent();
            newGame();
        }

        private void button_Click(object sender, EventArgs e)
        {
            pass();           
        }

        void pass()
        {
            int resNum;
            if (!int.TryParse(answer.Text, out resNum))
            {
                MessageBox.Show("Повторяю, я загадал число!", "Эй!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (resNum == num)
            {
                DialogResult result = MessageBox.Show($"Поздравляю, ты угадал за {step} попыток!", "Ура!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
                if (result == DialogResult.Retry)
                {
                    newGame();
                }
                else Close();
            }
            else
            {
                step++;
                labelAns.Text = (resNum > num) ? "Слишком много. Попробуй еще." : "Слишком мало. Попробуй ещё.";
            }
            answer.Clear();
        }

        void newGame()
        {
            num = r.Next(1, 100);
            step = 0;
            labelAns.Text = "";
        }


        private void answer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pass();
            }
        }
    }
}
