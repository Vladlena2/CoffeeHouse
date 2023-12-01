namespace Soft_Coffee
{
    partial class form5discount
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
            textBox1 = new TextBox();
            label3 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Arial", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(127, 28);
            label1.Name = "label1";
            label1.Size = new Size(547, 42);
            label1.TabIndex = 0;
            label1.Text = "Оформление скидочной карты";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(312, 116);
            label2.Name = "label2";
            label2.Size = new Size(165, 27);
            label2.TabIndex = 1;
            label2.Text = "Введите ФИО";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(270, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(251, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 208);
            label3.Name = "label3";
            label3.Size = new Size(297, 27);
            label3.TabIndex = 3;
            label3.Text = "Введите номер телефона";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(270, 238);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(251, 23);
            maskedTextBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(341, 298);
            button1.Name = "button1";
            button1.Size = new Size(105, 44);
            button1.TabIndex = 5;
            button1.Text = "Готово";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(312, 376);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(-7, -3);
            button2.Name = "button2";
            button2.Size = new Size(817, 96);
            button2.TabIndex = 7;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.BurlyWood;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(687, 376);
            button3.Name = "button3";
            button3.Size = new Size(75, 36);
            button3.TabIndex = 8;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form19
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form19";
            Text = "Form19";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
    }
}