namespace ProjWFaula16052022
{
    partial class FrmConsultaEstoque
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
            this.dgvEstoque = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstoque
            // 
            this.dgvEstoque.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.dgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstoque.Location = new System.Drawing.Point(12, 12);
            this.dgvEstoque.Name = "dgvEstoque";
            this.dgvEstoque.RowHeadersWidth = 51;
            this.dgvEstoque.RowTemplate.Height = 29;
            this.dgvEstoque.Size = new System.Drawing.Size(776, 426);
            this.dgvEstoque.TabIndex = 1;
            this.dgvEstoque.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEstoque_CellContentClick);
            // 
            // FrmConsultaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEstoque);
            this.Name = "FrmConsultaEstoque";
            this.Text = "FrmConsultaEstoque";
            this.Load += new System.EventHandler(this.FrmConsultaEstoque_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstoque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvEstoque;
    }
}