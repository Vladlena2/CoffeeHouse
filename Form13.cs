using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Soft_Coffee
{
    public partial class Form13 : Form
    {
        DatabaseHelper database = new DatabaseHelper();

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

            var login = textBox1.Text;
            var password = textBox2.Text;

            string queryString = "INSERT INTO users (group_id, name, password) VALUES(3, @login, @password) RETURNING id";

            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());
            command.Parameters.AddWithValue("@login", login);
            command.Parameters.AddWithValue("@password", password);

            database.openConnection();

            try
            {
                int userId = (int)command.ExecuteScalar();

                label4.Visible = false;
                MessageBox.Show("Вы успешно зарегистрировалаись", "Успешно!", MessageBoxButtons.OK);
                Form12 newForm = new Form12();
                this.Hide();
                newForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при создании аккаунта: " + ex.Message);
            }
            finally
            {
                database.closeConnection();
            }
            

        }

        private Boolean checkuser()
        {
            var loginUser = textBox1.Text;
            var passUser = textBox2.Text;

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            string queryString = "SELECT id, group_id, name, password FROM users WHERE name = @loginUser and password = @passUser";

            NpgsqlCommand command = new NpgsqlCommand(queryString, database.getConnection());
            command.Parameters.AddWithValue("@loginUser", loginUser);
            command.Parameters.AddWithValue("@passUser", passUser);

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь уже существует!");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
