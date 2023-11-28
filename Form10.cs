using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Soft_Coffee
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            label6.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 4;
            for (int i = 0; i < dataGridView1.RowCount; i++)
                for (int d = 0; d < dataGridView1.ColumnCount; d++)
                    dataGridView1.Rows[i].Cells[d].Value = nums1[i, d];

            string[,] combo = { { "0,3л" }, { "0,5" } };
        }
        string[,] nums1 = { { "1", "Латте", "", "60" }, { "2", "Капучино", "", "60" }, { "3", "Эспрессо", "", "60р" }, { "4", "Раф-кофе", "", "60р" }, { "5", "Флэт уайт", "", "60р" }, { "6", "Американо", "", "60р" }, { "7", "Бамбл", "", "60р" }, { "8", "Макиато", "", "60р" }, { "9", "Глясе", "", "60р" }, { "10", "Моккачино", "", "60р" } };

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                object[] items = new object[row.Cells.Count];
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    items[i] = row.Cells[i].Value;
                }
                dataGridView2.Rows.Add(items);

            }

            label4.Visible = true;

            {
                {
                    double sum = 0;
                    for (int i = 0; i < dataGridView2.RowCount - 0; i++)
                    {
                        if (dataGridView2.Rows[i].Visible)
                            sum += Convert.ToDouble(dataGridView2[3, i].Value);
                    }
                    label4.Text = sum.ToString();

                    Data1.Txt = label4.Text;

                }


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form14 newForm = new Form14();
            newForm.Show();
            label4.Visible = false;
            label6.Visible = true;
            double summ = double.Parse(label4.Text);
            double skidka = 0;
            if (summ > 0) skidka = 0.2;
            double itog = (summ - (skidka * summ));
            label6.Text = itog.ToString();


        }
    }
}
