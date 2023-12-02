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
using Npgsql;

namespace Soft_Coffee
{
    public partial class Form12 : Form
    {
        DatabaseHelper database = new DatabaseHelper();

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
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();

            string queryString = "SELECT id, name, password FROM users WHERE name = @loginUser AND password = @passUser";

            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());
            command.Parameters.AddWithValue("@loginUser", loginUser);
            command.Parameters.AddWithValue("@passUser", passUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                label4.Visible = false;
                MessageBox.Show("Вы успешно вошли", "Успешно!", MessageBoxButtons.OK);
                Form1 newForm = new Form1();
                this.Hide();
                newForm.ShowDialog();
            }
                
            else
            {
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
