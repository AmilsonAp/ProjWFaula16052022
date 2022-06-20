namespace ProjWFaula16052022
{
    partial class FrmConsultaVendedor
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
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(12, 12);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.RowHeadersWidth = 51;
            this.dgvVendedor.RowTemplate.Height = 29;
            this.dgvVendedor.Size = new System.Drawing.Size(776, 426);
            this.dgvVendedor.TabIndex = 1;
            this.dgvVendedor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendedor_CellContentClick);
            // 
            // FrmConsultaVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVendedor);
            this.Name = "FrmConsultaVendedor";
            this.Text = "FrmConsultaVendedor";
            this.Load += new System.EventHandler(this.FrmConsultaVendedor_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvVendedor;
    }
}