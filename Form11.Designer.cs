namespace Soft_Coffee
{
    partial class Form11
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            button2 = new Button();
            label2 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(152, 117, 88);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(-2, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 494);
            panel2.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(238, 219, 188);
            label7.Location = new Point(60, 262);
            label7.Name = "label7";
            label7.Size = new Size(105, 23);
            label7.TabIndex = 18;
            label7.Text = "Имя на карте";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(238, 219, 188);
            label6.Location = new Point(60, 209);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 17;
            label6.Text = "Срок действия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(238, 219, 188);
            label5.Location = new Point(346, 209);
            label5.Name = "label5";
            label5.Size = new Size(97, 23);
            label5.TabIndex = 16;
            label5.Text = "CVC/CVV";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Baskerville Old Face", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(238, 219, 188);
            button2.Location = new Point(90, 381);
            button2.Name = "button2";
            button2.Size = new Size(327, 45);
            button2.TabIndex = 15;
            button2.Text = "Оплатить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(238, 219, 188);
            label2.Location = new Point(100, 145);
            label2.Name = "label2";
            label2.Size = new Size(18, 23);
            label2.TabIndex = 14;
            label2.Text = "₽";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(60, 289);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(383, 27);
            textBox4.TabIndex = 12;
            textBox4.Enter += textBox4_Enter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 219, 188);
            label4.Location = new Point(60, 145);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 11;
            label4.Text = "label4";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(181, 236);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(262, 27);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.ForeColor = SystemColors.InactiveCaption;
            textBox2.Location = new Point(60, 236);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(115, 27);
            textBox2.TabIndex = 9;
            textBox2.Text = "ММ/ГГ";
            textBox2.Enter += textBox2_Enter;
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(60, 178);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(383, 27);
            textBox1.TabIndex = 8;
            textBox1.Text = "Введите номер карты";
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.Enter += textBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 219, 188);
            label3.Location = new Point(60, 125);
            label3.Name = "label3";
            label3.Size = new Size(115, 23);
            label3.TabIndex = 7;
            label3.Text = "Сумма оплаты";
            label3.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 219, 188);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-6, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(986, 121);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Baskerville Old Face", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(171, 47);
            label1.Name = "label1";
            label1.Size = new Size(216, 34);
            label1.TabIndex = 4;
            label1.Text = "Оплата заказа";
            label1.Click += label1_Click;
            // 
            // Form11
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 473);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form11";
            Text = "Form11";
            Load += Form11_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Label label7;
        private Label label6;
        private Label label5;
    }
}