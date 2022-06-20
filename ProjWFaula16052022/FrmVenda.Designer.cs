namespace ProjWFaula16052022
{
    partial class FrmVenda
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
            this.lblVenda = new System.Windows.Forms.Label();
            this.lblVendaCliente = new System.Windows.Forms.Label();
            this.lblVendaVendedor = new System.Windows.Forms.Label();
            this.btnVendaListar = new System.Windows.Forms.Button();
            this.btnVendaSalvar = new System.Windows.Forms.Button();
            this.cboProduto = new System.Windows.Forms.ComboBox();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVenda
            // 
            this.lblVenda.AutoSize = true;
            this.lblVenda.Location = new System.Drawing.Point(84, 60);
            this.lblVenda.Name = "lblVenda";
            this.lblVenda.Size = new System.Drawing.Size(62, 20);
            this.lblVenda.TabIndex = 0;
            this.lblVenda.Text = "Produto";
            // 
            // lblVendaCliente
            // 
            this.lblVendaCliente.AutoSize = true;
            this.lblVendaCliente.Location = new System.Drawing.Point(87, 137);
            this.lblVendaCliente.Name = "lblVendaCliente";
            this.lblVendaCliente.Size = new System.Drawing.Size(55, 20);
            this.lblVendaCliente.TabIndex = 4;
            this.lblVendaCliente.Text = "Cliente";
            // 
            // lblVendaVendedor
            // 
            this.lblVendaVendedor.AutoSize = true;
            this.lblVendaVendedor.Location = new System.Drawing.Point(85, 214);
            this.lblVendaVendedor.Name = "lblVendaVendedor";
            this.lblVendaVendedor.Size = new System.Drawing.Size(73, 20);
            this.lblVendaVendedor.TabIndex = 5;
            this.lblVendaVendedor.Text = "Vendedor";
            // 
            // btnVendaListar
            // 
            this.btnVendaListar.Location = new System.Drawing.Point(84, 315);
            this.btnVendaListar.Name = "btnVendaListar";
            this.btnVendaListar.Size = new System.Drawing.Size(94, 29);
            this.btnVendaListar.TabIndex = 6;
            this.btnVendaListar.Text = "LISTAR";
            this.btnVendaListar.UseVisualStyleBackColor = true;
            this.btnVendaListar.Click += new System.EventHandler(this.btnVendaListar_Click);
            // 
            // btnVendaSalvar
            // 
            this.btnVendaSalvar.Location = new System.Drawing.Point(288, 315);
            this.btnVendaSalvar.Name = "btnVendaSalvar";
            this.btnVendaSalvar.Size = new System.Drawing.Size(94, 29);
            this.btnVendaSalvar.TabIndex = 7;
            this.btnVendaSalvar.Text = "SALVAR";
            this.btnVendaSalvar.UseVisualStyleBackColor = true;
            this.btnVendaSalvar.Click += new System.EventHandler(this.btnVendaSalvar_Click);
            // 
            // cboProduto
            // 
            this.cboProduto.FormattingEnabled = true;
            this.cboProduto.Location = new System.Drawing.Point(91, 90);
            this.cboProduto.Name = "cboProduto";
            this.cboProduto.Size = new System.Drawing.Size(291, 28);
            this.cboProduto.TabIndex = 8;
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(91, 160);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(291, 28);
            this.cboCliente.TabIndex = 9;
            // 
            // cboVendedor
            // 
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(89, 240);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(293, 28);
            this.cboVendedor.TabIndex = 10;
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboVendedor);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.cboProduto);
            this.Controls.Add(this.btnVendaSalvar);
            this.Controls.Add(this.btnVendaListar);
            this.Controls.Add(this.lblVendaVendedor);
            this.Controls.Add(this.lblVendaCliente);
            this.Controls.Add(this.lblVenda);
            this.Name = "FrmVenda";
            this.Text = "FrmVenda";
            this.Load += new System.EventHandler(this.FrmVenda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblVenda;
        private Label lblVendaCliente;
        private Label lblVendaVendedor;
        private Button btnVendaListar;
        private Button btnVendaSalvar;
        private ComboBox cboProduto;
        private ComboBox cboCliente;
        private ComboBox cboVendedor;
    }
}