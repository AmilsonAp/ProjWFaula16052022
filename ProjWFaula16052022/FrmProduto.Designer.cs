namespace ProjWFaula16052022
{
    partial class FrmProduto
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
            this.lblIdProd = new System.Windows.Forms.Label();
            this.txtIdProd = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.lblDescProd = new System.Windows.Forms.Label();
            this.btnSalvarProd = new System.Windows.Forms.Button();
            this.btnListarProd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdProd
            // 
            this.lblIdProd.AutoSize = true;
            this.lblIdProd.Location = new System.Drawing.Point(116, 52);
            this.lblIdProd.Name = "lblIdProd";
            this.lblIdProd.Size = new System.Drawing.Size(22, 20);
            this.lblIdProd.TabIndex = 0;
            this.lblIdProd.Text = "Id";
            this.lblIdProd.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIdProd
            // 
            this.txtIdProd.Location = new System.Drawing.Point(116, 75);
            this.txtIdProd.Name = "txtIdProd";
            this.txtIdProd.Size = new System.Drawing.Size(112, 27);
            this.txtIdProd.TabIndex = 1;
            // 
            // txtDescProd
            // 
            this.txtDescProd.Location = new System.Drawing.Point(116, 154);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(255, 27);
            this.txtDescProd.TabIndex = 2;
            // 
            // lblDescProd
            // 
            this.lblDescProd.AutoSize = true;
            this.lblDescProd.Location = new System.Drawing.Point(117, 123);
            this.lblDescProd.Name = "lblDescProd";
            this.lblDescProd.Size = new System.Drawing.Size(74, 20);
            this.lblDescProd.TabIndex = 3;
            this.lblDescProd.Text = "Descrição";
            // 
            // btnSalvarProd
            // 
            this.btnSalvarProd.Location = new System.Drawing.Point(277, 214);
            this.btnSalvarProd.Name = "btnSalvarProd";
            this.btnSalvarProd.Size = new System.Drawing.Size(94, 29);
            this.btnSalvarProd.TabIndex = 7;
            this.btnSalvarProd.Text = "SALVAR";
            this.btnSalvarProd.UseVisualStyleBackColor = true;
            this.btnSalvarProd.Click += new System.EventHandler(this.btnSalvarProd_Click);
            // 
            // btnListarProd
            // 
            this.btnListarProd.Location = new System.Drawing.Point(116, 214);
            this.btnListarProd.Name = "btnListarProd";
            this.btnListarProd.Size = new System.Drawing.Size(94, 29);
            this.btnListarProd.TabIndex = 8;
            this.btnListarProd.Text = "LISTAR";
            this.btnListarProd.UseVisualStyleBackColor = true;
            this.btnListarProd.Click += new System.EventHandler(this.btnListarProd_Click);
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnListarProd);
            this.Controls.Add(this.btnSalvarProd);
            this.Controls.Add(this.lblDescProd);
            this.Controls.Add(this.txtDescProd);
            this.Controls.Add(this.txtIdProd);
            this.Controls.Add(this.lblIdProd);
            this.Name = "FrmProduto";
            this.Text = "Cadastrar Produto";
            this.Load += new System.EventHandler(this.FrmProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblIdProd;
        private TextBox txtIdProd;
        private TextBox txtDescProd;
        private Label lblDescProd;
        private Button btnSalvarProd;
        private Button btnListarProd;
    }
}