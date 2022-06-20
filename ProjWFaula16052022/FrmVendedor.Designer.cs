namespace ProjWFaula16052022
{
    partial class FrmVendedor
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
            this.lblIdVendedor = new System.Windows.Forms.Label();
            this.lblNomeVendedor = new System.Windows.Forms.Label();
            this.lblTelefoneVendedor = new System.Windows.Forms.Label();
            this.txtIdVendedor = new System.Windows.Forms.TextBox();
            this.txtNomeVendedor = new System.Windows.Forms.TextBox();
            this.txtTelefoneVendedor = new System.Windows.Forms.TextBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdVendedor
            // 
            this.lblIdVendedor.AutoSize = true;
            this.lblIdVendedor.Location = new System.Drawing.Point(76, 39);
            this.lblIdVendedor.Name = "lblIdVendedor";
            this.lblIdVendedor.Size = new System.Drawing.Size(22, 20);
            this.lblIdVendedor.TabIndex = 0;
            this.lblIdVendedor.Text = "Id";
            // 
            // lblNomeVendedor
            // 
            this.lblNomeVendedor.AutoSize = true;
            this.lblNomeVendedor.Location = new System.Drawing.Point(76, 88);
            this.lblNomeVendedor.Name = "lblNomeVendedor";
            this.lblNomeVendedor.Size = new System.Drawing.Size(50, 20);
            this.lblNomeVendedor.TabIndex = 1;
            this.lblNomeVendedor.Text = "Nome";
            // 
            // lblTelefoneVendedor
            // 
            this.lblTelefoneVendedor.AutoSize = true;
            this.lblTelefoneVendedor.Location = new System.Drawing.Point(76, 148);
            this.lblTelefoneVendedor.Name = "lblTelefoneVendedor";
            this.lblTelefoneVendedor.Size = new System.Drawing.Size(66, 20);
            this.lblTelefoneVendedor.TabIndex = 2;
            this.lblTelefoneVendedor.Text = "Telefone";
            // 
            // txtIdVendedor
            // 
            this.txtIdVendedor.Location = new System.Drawing.Point(76, 58);
            this.txtIdVendedor.Name = "txtIdVendedor";
            this.txtIdVendedor.Size = new System.Drawing.Size(76, 27);
            this.txtIdVendedor.TabIndex = 3;
            // 
            // txtNomeVendedor
            // 
            this.txtNomeVendedor.Location = new System.Drawing.Point(76, 111);
            this.txtNomeVendedor.Name = "txtNomeVendedor";
            this.txtNomeVendedor.Size = new System.Drawing.Size(272, 27);
            this.txtNomeVendedor.TabIndex = 4;
            // 
            // txtTelefoneVendedor
            // 
            this.txtTelefoneVendedor.Location = new System.Drawing.Point(76, 171);
            this.txtTelefoneVendedor.Name = "txtTelefoneVendedor";
            this.txtTelefoneVendedor.Size = new System.Drawing.Size(272, 27);
            this.txtTelefoneVendedor.TabIndex = 5;
            // 
            // btnListar
            // 
            this.btnListar.AllowDrop = true;
            this.btnListar.Location = new System.Drawing.Point(76, 245);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 29);
            this.btnListar.TabIndex = 8;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AllowDrop = true;
            this.btnSalvar.Location = new System.Drawing.Point(254, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(94, 29);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // FrmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtTelefoneVendedor);
            this.Controls.Add(this.txtNomeVendedor);
            this.Controls.Add(this.txtIdVendedor);
            this.Controls.Add(this.lblTelefoneVendedor);
            this.Controls.Add(this.lblNomeVendedor);
            this.Controls.Add(this.lblIdVendedor);
            this.Name = "FrmVendedor";
            this.Text = "Cadastrar Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdVendedor;
        private Label lblNomeVendedor;
        private Label lblTelefoneVendedor;
        private TextBox txtIdVendedor;
        private TextBox txtNomeVendedor;
        private TextBox txtTelefoneVendedor;
        private Button btnListar;
        private Button btnSalvar;
    }
}