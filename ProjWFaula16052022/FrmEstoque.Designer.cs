﻿namespace ProjWFaula16052022
{
    partial class FrmEstoque
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
            this.btnConsultarEstoque = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConsultarEstoque
            // 
            this.btnConsultarEstoque.Location = new System.Drawing.Point(12, 12);
            this.btnConsultarEstoque.Name = "btnConsultarEstoque";
            this.btnConsultarEstoque.Size = new System.Drawing.Size(94, 29);
            this.btnConsultarEstoque.TabIndex = 8;
            this.btnConsultarEstoque.Text = "CONSULTAR";
            this.btnConsultarEstoque.UseVisualStyleBackColor = true;
            this.btnConsultarEstoque.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // FrmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultarEstoque);
            this.Name = "FrmEstoque";
            this.Text = "Estoque";
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnConsultarEstoque;
    }
}