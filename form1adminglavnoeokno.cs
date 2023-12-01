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
    public partial class form15 : Form
    {
        public form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form2menuredactor frm16 = new form2menuredactor();
            frm16.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form3newuser frm17 = new form3newuser();
            frm17.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            form5discount frm19 = new form5discount();
            frm19.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form4analitic frm18 = new form4analitic();    
            frm18.Show();
                this.Hide();
        }
    }
}
