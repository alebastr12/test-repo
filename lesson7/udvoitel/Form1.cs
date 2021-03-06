﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udvoitel
{
    public delegate int func(int n);
    public partial class Form1 : Form
    {
        int numCur = 0;
        int numRes = -1;
        int step = 0;
        Stack<int> stepStack = new Stack<int>();
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        public void stepFun(func f)
        {
            step++;
            stepStack.Push(numCur);
            cancel.Enabled = true;
            numCur = f(numCur);
            if (numCur == numRes)
            {
                DialogResult result = MessageBox.Show("Поздравляю, вы победили! Сыграть ещё?", "Ура!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    newGame();
                }
            }
            rePrint();

        }
        static int incF(int n)
        {
            return n + 1;
        }
        static int mul2F(int n)
        {
            return n * 2;
        }

        private void inc_Click(object sender, EventArgs e)
        {
            stepFun(incF);
        }

        private void игратьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
        }
        void newGame()
        {
            numRes = r.Next(10, 100);
            numCur = 0;
            step = 0;
            stepStack.Clear();
            labelInfo.Text = string.Format($"Должен получить {numRes}");
            rePrint();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mul2_Click(object sender, EventArgs e)
        {
            stepFun(mul2F);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            numCur = stepStack.Pop();
            step--;
            if (stepStack.Count == 0)
            {
                cancel.Enabled = false;
            }
            rePrint();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            step = 0;
            numCur = 0;
            stepStack.Clear();
            cancel.Enabled = false;
            rePrint();
        }
        void rePrint()
        {
            labelNum.Text = numCur.ToString();
            status.Text = string.Format($"Количество шагов: {step}");
        }
    }
}
