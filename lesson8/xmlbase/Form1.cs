using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace xmlbase
{
    public partial class Form1 : Form
    {
        BindingSource source;
        List<Element> list;
        string filename="data.xml";
        public Form1()
        {
            InitializeComponent();
            list = XmlSaveLoad.Load(ref filename);
            this.Text = filename;
            source = new BindingSource
            {
                DataSource = list
            };
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = source;
            dataGridView1.Columns[0].HeaderText = "Имя";
            dataGridView1.Columns[1].HeaderText = "День рождения";
            dataGridView1.DataError += DataGridView1_DataError;
        }

        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show($"Ошибка формата в строке {e.RowIndex}, столбце {e.ColumnIndex}. Изменеия не будут сохранены.\n" +
                $"{e.Exception.Message}","Ошибка!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            e.Cancel = true; 
            dataGridView1.CancelEdit(); 
            source.RemoveCurrent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filename != string.Empty)
            {
                if (!XmlSaveLoad.Save(filename, list))
                {
                    this.Text = filename = string.Empty;
                }
            } else сохранитьКакToolStripMenuItem_Click(sender, e);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Xml файлы (*.xml)|*.xml";
            DialogResult res = openFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                filename = openFile.FileName;
                list = XmlSaveLoad.Load(ref filename);
                this.Text = filename;
                source.DataSource = list;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDiag = new SaveFileDialog();
            DialogResult res = saveDiag.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (XmlSaveLoad.Save(saveDiag.FileName, list))
                {
                    this.Text = filename = saveDiag.FileName;
                }
            }
        }
    }
}
