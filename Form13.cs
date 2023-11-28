using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soft_Coffee
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        private void Form13_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '●';
            textBox2.MaxLength = 25;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                label4.Visible = true;
            }
            else
            {
                label4.Visible = false;
                MessageBox.Show("Вы успешно зарегистрировалаись", "Успешно!", MessageBoxButtons.OK);
                Form12 newForm = new Form12();
                this.Hide();
                newForm.ShowDialog();
            }

        }

    }
}
