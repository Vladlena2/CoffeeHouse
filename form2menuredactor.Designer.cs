namespace Soft_Coffee
{
    partial class form2menuredactor
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Tan;
            label1.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(24, 18);
            label1.Name = "label1";
            label1.Size = new Size(110, 40);
            label1.TabIndex = 0;
            label1.Text = "Меню";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Tan;
            label2.Font = new Font("Arial Rounded MT Bold", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(595, 18);
            label2.Name = "label2";
            label2.Size = new Size(113, 40);
            label2.TabIndex = 1;
            label2.Text = "Заказ";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 80);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(513, 293);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(24, 388);
            button1.Name = "button1";
            button1.Size = new Size(191, 32);
            button1.TabIndex = 4;
            button1.Text = "Удалить";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 14.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(346, 388);
            button2.Name = "button2";
            button2.Size = new Size(191, 32);
            button2.TabIndex = 5;
            button2.Text = "Редактирование";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(845, 244);
            button3.Name = "button3";
            button3.Size = new Size(191, 32);
            button3.TabIndex = 6;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(604, 123);
            label3.Name = "label3";
            label3.Size = new Size(93, 22);
            label3.TabIndex = 7;
            label3.Text = "Название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(778, 123);
            label4.Name = "label4";
            label4.Size = new Size(71, 22);
            label4.TabIndex = 8;
            label4.Text = "Объём";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(936, 123);
            label5.Name = "label5";
            label5.Size = new Size(55, 22);
            label5.TabIndex = 9;
            label5.Text = "Цена";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(604, 163);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(778, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(936, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.FlatAppearance.BorderColor = Color.Tan;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Tan;
            button4.FlatAppearance.MouseOverBackColor = Color.Tan;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Tan;
            button4.Location = new Point(-3, 1);
            button4.Name = "button4";
            button4.Size = new Size(1158, 73);
            button4.TabIndex = 13;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.BurlyWood;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlText;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(1008, 388);
            button5.Name = "button5";
            button5.Size = new Size(88, 32);
            button5.TabIndex = 14;
            button5.Text = "Назад";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form16
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            ClientSize = new Size(1134, 447);
            Controls.Add(button5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Name = "Form16";
            Text = "Form16";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button4;
        private Button button5;
    }
}