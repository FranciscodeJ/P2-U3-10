namespace Práctica_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            listBox2 = new ListBox();
            listBox3 = new ListBox();
            listBox4 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(348, 527);
            button1.Name = "button1";
            button1.Size = new Size(273, 60);
            button1.TabIndex = 0;
            button1.Text = "Calcular Valores";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PaleGoldenrod;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 34;
            listBox1.Location = new Point(45, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(169, 306);
            listBox1.TabIndex = 15;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(267, 25);
            label1.Name = "label1";
            label1.Size = new Size(395, 35);
            label1.TabIndex = 16;
            label1.Text = "Calcular Valores de una Ecuación";
            label1.Click += label1_Click;
            // 
            // listBox2
            // 
            listBox2.BackColor = Color.PaleGoldenrod;
            listBox2.BorderStyle = BorderStyle.None;
            listBox2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 34;
            listBox2.Location = new Point(278, 192);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(169, 306);
            listBox2.TabIndex = 21;
            // 
            // listBox3
            // 
            listBox3.BackColor = Color.PaleGoldenrod;
            listBox3.BorderStyle = BorderStyle.None;
            listBox3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 34;
            listBox3.Location = new Point(509, 192);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(169, 306);
            listBox3.TabIndex = 22;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox4
            // 
            listBox4.BackColor = Color.PaleGoldenrod;
            listBox4.BorderStyle = BorderStyle.None;
            listBox4.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 34;
            listBox4.Location = new Point(739, 192);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(169, 306);
            listBox4.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(384, 78);
            label2.Name = "label2";
            label2.Size = new Size(178, 35);
            label2.TabIndex = 24;
            label2.Text = "Z= X^2 + X^3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(107, 138);
            label3.Name = "label3";
            label3.Size = new Size(34, 35);
            label3.TabIndex = 25;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(332, 138);
            label4.Name = "label4";
            label4.Size = new Size(64, 35);
            label4.TabIndex = 26;
            label4.Text = "X^2";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(557, 138);
            label5.Name = "label5";
            label5.Size = new Size(64, 35);
            label5.TabIndex = 27;
            label5.Text = "X^3";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Poor Richard", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(809, 138);
            label6.Name = "label6";
            label6.Size = new Size(31, 35);
            label6.TabIndex = 28;
            label6.Text = "Z";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(966, 623);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox4);
            Controls.Add(listBox3);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ListBox listBox1;
        private Label label1;
        private ListBox listBox2;
        private ListBox listBox3;
        private ListBox listBox4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}