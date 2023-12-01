namespace Soft_Coffee
{
    partial class form4analitic
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
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(51, 25);
            label1.Name = "label1";
            label1.Size = new Size(201, 42);
            label1.TabIndex = 1;
            label1.Text = "Аналитика";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 108);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(71, 18);
            label2.TabIndex = 2;
            label2.Text = "Выручка";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Moccasin;
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "за день", "за месяц" });
            comboBox1.Location = new Point(128, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Tan;
            button1.Location = new Point(150, 367);
            button1.Name = "button1";
            button1.Size = new Size(302, 47);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Tan;
            label3.Font = new Font("Arial", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(159, 374);
            label3.Name = "label3";
            label3.Size = new Size(75, 31);
            label3.TabIndex = 5;
            label3.Text = "Итог:";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Tan;
            button2.Location = new Point(-9, -1);
            button2.Name = "button2";
            button2.Size = new Size(820, 82);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.BurlyWood;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(611, 385);
            button3.Name = "button3";
            button3.Size = new Size(102, 29);
            button3.TabIndex = 7;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form18
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Name = "Form18";
            Text = "Form18";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Button button1;
        private Label label3;
        private Button button2;
        private Button button3;
    }
}