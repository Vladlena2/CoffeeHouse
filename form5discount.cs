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
    public partial class form5discount : Form
    {
        public form5discount()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = maskedTextBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            form15 frm15 = new form15();
            frm15.Show();
            this.Hide();
        }
    }
}
            

