using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testgrid
{
    public partial class Form1 : Form
    {
        BindingSource source;
        List<Element> list;
        string filename;
        public Form1()
        {
            InitializeComponent();
            list = new List<Element>();
            list.Add(new Element("Имя1", new DateTime(1990,1,1)));
            list.Add(new Element("Имя2", new DateTime(1990, 1, 2)));
            list.Add(new Element("Имя3", new DateTime(1990, 1, 3)));
            source = new BindingSource();
            source.DataSource = list;
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
            SaveFileDialog saveDiag = new SaveFileDialog();
            DialogResult res = saveDiag.ShowDialog();
            if (res == DialogResult.OK)
            {
                XmlSaveLoad.XmlSave(saveDiag.FileName, list);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Xml файлы (*.xml)|*.xml";
            DialogResult res = openFile.ShowDialog();
            if (res == DialogResult.OK)
            {
                list = XmlSaveLoad.XmlLoad(openFile.FileName);
                source.DataSource = list;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
