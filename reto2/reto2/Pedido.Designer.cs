namespace reto2
{
    partial class Pedido
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
            dataGridView1 = new DataGridView();
            ID_Factura = new DataGridViewTextBoxColumn();
            Sucursal = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID_Factura, Sucursal, Estado, Valor });
            dataGridView1.Location = new Point(3, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(441, 417);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID_Factura
            // 
            ID_Factura.HeaderText = "ID_Factura";
            ID_Factura.Name = "ID_Factura";
            // 
            // Sucursal
            // 
            Sucursal.HeaderText = "Sucursal";
            Sucursal.Name = "Sucursal";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            // 
            // Pedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Name = "Pedido";
            Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID_Factura;
        private DataGridViewTextBoxColumn Sucursal;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Valor;
    }
}