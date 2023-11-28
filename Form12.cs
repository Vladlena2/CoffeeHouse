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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        private void Form12_Load(object sender, EventArgs e)
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
                MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK);
                Form1 newForm = new Form1();
                this.Hide();
                newForm.ShowDialog();
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form13 Newform = new Form13();
            this.Hide();
            Newform.ShowDialog();
        }



    }
}
