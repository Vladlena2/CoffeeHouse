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

namespace Soft_Coffee
{
    public partial class Form7 : Form
    {
        Random rnd = new Random();
        string[][] order =
        {
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2],
            new string[2]
        };
        int orderCount = 0;
        string[] drinks = { "Эспрессо", "Капучино", "Латте", "Айс-Латте", "Глясе", "Бамбл", "Колд Брю", "Раф", "Мокачино" };
        public Form7()
        {
            InitializeComponent();
            for (int i = 0; i < order.Length; i++)
            {
                if (!String.IsNullOrEmpty(Convert.ToString(order[i][0])))
                {
                    orderCount++;
                }
            }

            label2.Text = $"У вас {orderCount} напитков в корзине";
        }


        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            {

                groupBox1.Visible = true;

                order[orderCount] = StaticData.DataBuffer;

                orderCount = 0;

                for (int i = 0; i < order.Length; i++)
                {
                    if (!String.IsNullOrEmpty(Convert.ToString(order[i][0])))
                    {
                        orderCount++;

                        GetAll(groupBox1, typeof(System.Windows.Forms.Label)).ToArray()[i].Visible = true;
                        GetAll(groupBox1, typeof(System.Windows.Forms.Label)).ToArray()[i].Text = $"[{i}] {order[i][0]}";
                    }
                }
                Form8 newForm = new Form8();
                newForm.Show();
                bool coffee = true;
                MessageBox.Show(coffee ? "Впишите название напитка, который хотите добавить в заказ" : "Not checked");
                MessageBox.Show(false ? "Checked" : "А затем добавьте в корзину");
                label2.Text = $"Количество напитков: {orderCount}";
            }
        }
    }
}
