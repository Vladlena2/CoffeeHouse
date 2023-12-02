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
    public partial class Form10 : Form
    {
        // Создание экземпляра класса для работы с базой данных
        DatabaseHelper databaseHelper = new DatabaseHelper();

        // Инициализация формы
        public Form10()
        {
            InitializeComponent();
        }

        // Обработчик события загрузки формы
        private void Form10_Load(object sender, EventArgs e)
        {
            // Установка режима выделения строк в DataGridView
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            CreateColumnsDataGridView1();
            CreateColumnsDataGridView2();
            RefreshDataGrid(dataGridView1);
        }

        private void CreateColumnsDataGridView1()
        {
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Volume", "Объем");
            dataGridView1.Columns.Add("Price", "Цена");
        }

        private void CreateColumnsDataGridView2()
        {
            dataGridView2.Columns.Add("Name", "Название");
            dataGridView2.Columns.Add("Volume", "Объем");
            dataGridView2.Columns.Add("Price", "Цена");
        }

        private void readSingleRow(DataGridView dgr, IDataRecord record)
        {
            dgr.Rows.Add(record.GetString(0), record.GetString(1), record.GetInt32(2));
        }

        private void RefreshDataGrid(DataGridView dgr)
        {
            dgr.Rows.Clear();

            string queryString = "SELECT d.title, rd.razmer, d.price + rd.price AS total_price" +
                                  " FROM drinks d CROSS JOIN razmer_drink rd;";

            NpgsqlCommand command = new NpgsqlCommand(queryString, databaseHelper.getConnection());

            databaseHelper.openConnection();

            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                readSingleRow(dgr, reader);
            }

            reader.Close();

        }

        // Обработчик кнопки "Добавить"
        private void button1_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем индекс выделенной строки
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Проверяем, что индекс строки действителен
                if (selectedIndex >= 0 && selectedIndex < dataGridView1.Rows.Count)
                {
                    // Создаем новую строку для второго DataGridView
                    DataGridViewRow newRow = new DataGridViewRow();

                    // Копируем значения ячеек из выделенной строки
                    foreach (DataGridViewCell cell in dataGridView1.Rows[selectedIndex].Cells)
                    {
                        // Явное приведение типа для добавления в коллекцию новой строки
                        newRow.Cells.Add(new DataGridViewTextBoxCell { Value = cell.Value });
                    }

                    // Добавляем новую строку во второй DataGridView
                    dataGridView2.Rows.Add(newRow);
                }
            }

            label4.Visible = true;
            // Инициализируем переменную для хранения суммы цен
            decimal total = 0;

            // Проходим по всем строкам DataGridView
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                // Получаем значение ячейки в столбце "Цена" (замените "Price" на реальное имя столбца)
                if (row.Cells["Price"].Value != null && decimal.TryParse(row.Cells["Price"].Value.ToString(), out decimal price))
                {
                    // Суммируем значение цены
                    total += price;
                }
            }

            // Выводим сумму в Label (замените labelTotal на имя вашего Label)
            label4.Text = $"{total:C}";
        }

        // Обработчик кнопки "Скидочная карта"
        private void button3_Click(object sender, EventArgs e)
        {
            // Создание новой формы для оплаты
            Form14 newForm = new Form14();
            newForm.Show();

            // Скрытие и отображение необходимых элементов
            label4.Visible = false;
        }

        // Обработчик кнопки "Оплата"
        private void button2_Click(object sender, EventArgs e)
        {
            // Создание новой формы для оплаты
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
