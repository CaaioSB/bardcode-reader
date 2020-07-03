namespace BarcodeReader.Formulario
{
    partial class frmGetProduto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarProdutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBarcodeProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarProdutoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(276, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastarProdutoToolStripMenuItem
            // 
            this.cadastarProdutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarProdutoToolStripMenuItem1});
            this.cadastarProdutoToolStripMenuItem.Name = "cadastarProdutoToolStripMenuItem";
            this.cadastarProdutoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.cadastarProdutoToolStripMenuItem.Text = "Produto";
            // 
            // cadastarProdutoToolStripMenuItem1
            // 
            this.cadastarProdutoToolStripMenuItem1.Name = "cadastarProdutoToolStripMenuItem1";
            this.cadastarProdutoToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.cadastarProdutoToolStripMenuItem1.Text = "Cadastar Produto";
            this.cadastarProdutoToolStripMenuItem1.Click += new System.EventHandler(this.cadastarProdutoToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "BARCODE";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "NOME DO PRODUTO";
            // 
            // txtBarcodeProduto
            // 
            this.txtBarcodeProduto.Location = new System.Drawing.Point(12, 86);
            this.txtBarcodeProduto.Name = "txtBarcodeProduto";
            this.txtBarcodeProduto.Size = new System.Drawing.Size(249, 20);
            this.txtBarcodeProduto.TabIndex = 1;
            this.txtBarcodeProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeProduto_KeyUp);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Location = new System.Drawing.Point(12, 47);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.ReadOnly = true;
            this.txtNomeProduto.Size = new System.Drawing.Size(249, 20);
            this.txtNomeProduto.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 35);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // frmGetProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 118);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarcodeProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmGetProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            this.Load += new System.EventHandler(this.frmGetProduto_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarProdutoToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBarcodeProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}