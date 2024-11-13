namespace reto2
{
    partial class venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(venta));
            listBox1 = new ListBox();
            button3 = new Button();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(255, 255, 128);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 164);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(369, 274);
            listBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Location = new Point(540, 300);
            button3.Name = "button3";
            button3.Size = new Size(208, 32);
            button3.TabIndex = 3;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(255, 255, 128);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(539, 189);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(209, 23);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.BackColor = Color.FromArgb(255, 255, 128);
            numericUpDown1.Location = new Point(540, 238);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(208, 23);
            numericUpDown1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 152);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Yellow;
            button1.Location = new Point(540, 358);
            button1.Name = "button1";
            button1.Size = new Size(208, 32);
            button1.TabIndex = 7;
            button1.Text = "Generar factura";
            button1.UseVisualStyleBackColor = false;
            // 
            // venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Name = "venta";
            Text = "venta";
            Load += venta_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button3;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}