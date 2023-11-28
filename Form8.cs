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
    public partial class Form8 : Form
    {
        string[] orderProperties = { "", "" };

    public Form8()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count > 0)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
                checkedListBox1.SetItemChecked(checkedListBox1.SelectedIndex, false);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                orderProperties[0] = Convert.ToString(textBox1.Text);
                orderProperties[1] = Convert.ToString(checkedListBox1.SelectedIndex);
                StaticData.DataBuffer = orderProperties;
                this.Hide();
            }
        }
    }
}
