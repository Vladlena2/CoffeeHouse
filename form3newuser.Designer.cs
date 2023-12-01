namespace Soft_Coffee
{
    partial class form3newuser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form3newuser));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial Rounded MT Bold", 30.75F, FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(263, 48);
            label1.Name = "label1";
            label1.Size = new Size(415, 48);
            label1.TabIndex = 1;
            label1.Text = "Администрирование";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(44, 161);
            label2.Name = "label2";
            label2.Size = new Size(60, 22);
            label2.TabIndex = 2;
            label2.Text = "Логин";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(230, 161);
            label3.Name = "label3";
            label3.Size = new Size(76, 22);
            label3.TabIndex = 3;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(391, 161);
            label4.Name = "label4";
            label4.Size = new Size(164, 22);
            label4.TabIndex = 4;
            label4.Text = "Тип пользователя";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(44, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(230, 211);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Администратор", "Бариста", "Покупатель" });
            comboBox1.Location = new Point(399, 211);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(44, 349);
            button1.Name = "button1";
            button1.Size = new Size(153, 39);
            button1.TabIndex = 8;
            button1.Text = "Сохранить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(402, 349);
            button2.Name = "button2";
            button2.Size = new Size(153, 39);
            button2.TabIndex = 9;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.BurlyWood;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(665, 355);
            button3.Name = "button3";
            button3.Size = new Size(88, 33);
            button3.TabIndex = 10;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form17
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form17";
            Text = "Form17";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}