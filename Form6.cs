using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Soft_Coffee
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            comboBox1.DataSource = Data.drink;
            comboBox1.DisplayMember = "typeDrink";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drink drinks = (Drink)comboBox1.SelectedItem;
            MessageBox.Show(drinks.promocode);
        }
        public class Drink
        {
            public string typeDrink { get; set; }
            public string promocode { get; set; }
        }

        public static class Data
        {
            public static List<Drink> drink = new List<Drink>()
            {
                new Drink()
                {
                 typeDrink = "Бамбл",
                 promocode = "SOFTGFI0TQE7"
                },
                new Drink()
                {
                 typeDrink = "Колд брю",
                 promocode = "SOFTP3FKNILP"
                },
                new Drink()
                {
                 typeDrink = "Айс-латте",
                 promocode = "SOFTZ45SNOLI"
                },
                new Drink()
                {
                 typeDrink = "Глясе",
                 promocode = "SOFT29K2J8CF"
                }
            };
        }
    }
}

