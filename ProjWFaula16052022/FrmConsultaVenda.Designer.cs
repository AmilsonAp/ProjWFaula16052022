namespace ProjWFaula16052022
{
    partial class FrmConsultaVenda
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
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVenda
            // 
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(36, 41);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.RowHeadersWidth = 51;
            this.dgvVenda.RowTemplate.Height = 29;
            this.dgvVenda.Size = new System.Drawing.Size(703, 367);
            this.dgvVenda.TabIndex = 0;
            // 
            // FrmConsultaVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvVenda);
            this.Name = "FrmConsultaVenda";
            this.Text = "FrmConsultaVenda";
            this.Load += new System.EventHandler(this.FrmConsultaVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvVenda;
    }
}