namespace Soft_Coffee
{
    partial class Form14
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
            button1 = new Button();
            maskedTextBox1 = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            button2 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(238, 219, 188);
            button1.Location = new Point(251, 319);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(299, 48);
            button1.TabIndex = 14;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(238, 219, 188);
            maskedTextBox1.Location = new Point(251, 271);
            maskedTextBox1.Margin = new Padding(3, 4, 3, 4);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(75, 27);
            maskedTextBox1.TabIndex = 13;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(238, 219, 188);
            label4.Location = new Point(251, 244);
            label4.Name = "label4";
            label4.Size = new Size(199, 22);
            label4.TabIndex = 12;
            label4.Text = "Введите дату рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(238, 219, 188);
            label3.Location = new Point(251, 167);
            label3.Name = "label3";
            label3.Size = new Size(220, 22);
            label3.TabIndex = 11;
            label3.Text = "Введите  номер телефона";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(238, 219, 188);
            label2.Location = new Point(251, 83);
            label2.Name = "label2";
            label2.Size = new Size(120, 22);
            label2.TabIndex = 10;
            label2.Text = "Введите ФИО";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(238, 219, 188);
            textBox2.Location = new Point(251, 191);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(299, 41);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(238, 219, 188);
            textBox1.Location = new Point(251, 107);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 41);
            textBox1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(152, 117, 88);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(0, -21);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(970, 496);
            panel2.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(238, 219, 188);
            button2.Location = new Point(217, 252);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(299, 48);
            button2.TabIndex = 7;
            button2.Text = "Готово";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(238, 219, 188);
            label5.Location = new Point(217, 166);
            label5.Name = "label5";
            label5.Size = new Size(220, 22);
            label5.TabIndex = 4;
            label5.Text = "Введите  номер телефона";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(238, 219, 188);
            textBox3.Location = new Point(217, 192);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(299, 41);
            textBox3.TabIndex = 1;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 450);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form14";
            Text = "Form14";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox maskedTextBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Panel panel2;
        private Button button2;
        private Label label5;
        private TextBox textBox3;
    }
}