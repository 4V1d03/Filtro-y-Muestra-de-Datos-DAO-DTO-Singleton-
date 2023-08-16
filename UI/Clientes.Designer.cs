namespace Mostrar_y_Filtrar_Datos.UI
{
    partial class Clientes
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
            txtbuscar = new TextBox();
            btnbuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(52, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(970, 316);
            dataGridView1.TabIndex = 0;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(52, 55);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.Size = new Size(313, 27);
            txtbuscar.TabIndex = 1;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // btnbuscar
            // 
            btnbuscar.Location = new Point(371, 54);
            btnbuscar.Name = "btnbuscar";
            btnbuscar.Size = new Size(96, 29);
            btnbuscar.TabIndex = 2;
            btnbuscar.Text = "Buscar";
            btnbuscar.UseVisualStyleBackColor = true;
            btnbuscar.Click += btnbuscar_Click;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 479);
            Controls.Add(btnbuscar);
            Controls.Add(txtbuscar);
            Controls.Add(dataGridView1);
            Name = "Clientes";
            Text = "Clientes";
            Load += Clientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtbuscar;
        private Button btnbuscar;
    }
}