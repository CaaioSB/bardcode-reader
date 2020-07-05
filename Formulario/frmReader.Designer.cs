namespace BarcodeReader.Formulario
{
    partial class frmReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReader));
            this.txtBarcodeProduto = new System.Windows.Forms.TextBox();
            this.uiTxtNomeProduto = new uiCSB.Component.uiTextBox();
            this.uiPanel1 = new uiCSB.Component.uiPanel();
            this.uiButton3 = new uiCSB.Component.uiButton();
            this.uiBtnAdicionar = new uiCSB.Component.uiButton();
            this.uiBtnFechar = new uiCSB.Component.uiButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiBtnRemover = new uiCSB.Component.uiButton();
            this.uiBtnAlterar = new uiCSB.Component.uiButton();
            this.uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBarcodeProduto
            // 
            this.txtBarcodeProduto.Location = new System.Drawing.Point(308, 113);
            this.txtBarcodeProduto.Name = "txtBarcodeProduto";
            this.txtBarcodeProduto.Size = new System.Drawing.Size(33, 20);
            this.txtBarcodeProduto.TabIndex = 1;
            this.txtBarcodeProduto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeProduto_KeyUp);
            // 
            // uiTxtNomeProduto
            // 
            this.uiTxtNomeProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.uiTxtNomeProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxtNomeProduto.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiTxtNomeProduto.ForeColor = System.Drawing.Color.White;
            this.uiTxtNomeProduto.Location = new System.Drawing.Point(12, 151);
            this.uiTxtNomeProduto.Name = "uiTxtNomeProduto";
            this.uiTxtNomeProduto.Size = new System.Drawing.Size(335, 26);
            this.uiTxtNomeProduto.TabIndex = 11;
            this.uiTxtNomeProduto.TabStop = false;
            this.uiTxtNomeProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTxtNomeProduto.ValidadeType = uiCSB.Component.uiTextBox.Validate.None;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiButton3);
            this.uiPanel1.Controls.Add(this.uiBtnAdicionar);
            this.uiPanel1.Controls.Add(this.uiBtnFechar);
            this.uiPanel1.Controls.Add(this.label2);
            this.uiPanel1.Controls.Add(this.pictureBox2);
            this.uiPanel1.Controls.Add(this.label1);
            this.uiPanel1.Draggable = true;
            this.uiPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiPanel1.Location = new System.Drawing.Point(-1, -1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(74)))), ((int)(((byte)(188)))));
            this.uiPanel1.PanelRadius = 0;
            this.uiPanel1.Size = new System.Drawing.Size(361, 101);
            this.uiPanel1.TabIndex = 12;
            // 
            // uiButton3
            // 
            this.uiButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiButton3.BorderColor = System.Drawing.Color.Transparent;
            this.uiButton3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiButton3.FlatAppearance.BorderSize = 0;
            this.uiButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiButton3.Location = new System.Drawing.Point(273, 3);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiButton3.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.uiButton3.Size = new System.Drawing.Size(24, 20);
            this.uiButton3.TabIndex = 5;
            this.uiButton3.Text = "?";
            this.uiButton3.TextColor = System.Drawing.Color.White;
            this.uiButton3.UseVisualStyleBackColor = false;
            // 
            // uiBtnAdicionar
            // 
            this.uiBtnAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnAdicionar.BorderColor = System.Drawing.Color.Transparent;
            this.uiBtnAdicionar.ButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.uiBtnAdicionar.FlatAppearance.BorderSize = 0;
            this.uiBtnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnAdicionar.Location = new System.Drawing.Point(303, 3);
            this.uiBtnAdicionar.Name = "uiBtnAdicionar";
            this.uiBtnAdicionar.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnAdicionar.OnHoverButtonColor = System.Drawing.Color.CadetBlue;
            this.uiBtnAdicionar.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnAdicionar.Size = new System.Drawing.Size(24, 20);
            this.uiBtnAdicionar.TabIndex = 4;
            this.uiBtnAdicionar.Text = "+";
            this.uiBtnAdicionar.TextColor = System.Drawing.Color.White;
            this.uiBtnAdicionar.UseVisualStyleBackColor = false;
            this.uiBtnAdicionar.Click += new System.EventHandler(this.uiBtnAdicionar_Click);
            // 
            // uiBtnFechar
            // 
            this.uiBtnFechar.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnFechar.BorderColor = System.Drawing.Color.Transparent;
            this.uiBtnFechar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiBtnFechar.FlatAppearance.BorderSize = 0;
            this.uiBtnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnFechar.Location = new System.Drawing.Point(333, 3);
            this.uiBtnFechar.Name = "uiBtnFechar";
            this.uiBtnFechar.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnFechar.OnHoverButtonColor = System.Drawing.Color.Red;
            this.uiBtnFechar.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnFechar.Size = new System.Drawing.Size(24, 20);
            this.uiBtnFechar.TabIndex = 3;
            this.uiBtnFechar.Text = "X";
            this.uiBtnFechar.TextColor = System.Drawing.Color.White;
            this.uiBtnFechar.UseVisualStyleBackColor = false;
            this.uiBtnFechar.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(143, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "Com o seu dispositivo USB de leitor de código de barras você pode pesquisar um ob" +
    "jeto já cadastrado na aplicação anteriormente.\r\n";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::BarcodeReader.Properties.Resources.peopleontable;
            this.pictureBox2.Location = new System.Drawing.Point(5, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(136, 90);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(139, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Barcode";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // uiBtnRemover
            // 
            this.uiBtnRemover.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnRemover.BorderColor = System.Drawing.Color.Transparent;
            this.uiBtnRemover.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiBtnRemover.FlatAppearance.BorderSize = 0;
            this.uiBtnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnRemover.Location = new System.Drawing.Point(12, 183);
            this.uiBtnRemover.Name = "uiBtnRemover";
            this.uiBtnRemover.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnRemover.OnHoverButtonColor = System.Drawing.Color.Red;
            this.uiBtnRemover.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnRemover.Size = new System.Drawing.Size(335, 20);
            this.uiBtnRemover.TabIndex = 6;
            this.uiBtnRemover.Text = "REMOVER";
            this.uiBtnRemover.TextColor = System.Drawing.Color.White;
            this.uiBtnRemover.UseVisualStyleBackColor = false;
            this.uiBtnRemover.Click += new System.EventHandler(this.uiBtnRemover_Click);
            // 
            // uiBtnAlterar
            // 
            this.uiBtnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnAlterar.BorderColor = System.Drawing.Color.Transparent;
            this.uiBtnAlterar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiBtnAlterar.FlatAppearance.BorderSize = 0;
            this.uiBtnAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnAlterar.Location = new System.Drawing.Point(12, 209);
            this.uiBtnAlterar.Name = "uiBtnAlterar";
            this.uiBtnAlterar.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnAlterar.OnHoverButtonColor = System.Drawing.Color.Blue;
            this.uiBtnAlterar.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnAlterar.Size = new System.Drawing.Size(335, 20);
            this.uiBtnAlterar.TabIndex = 13;
            this.uiBtnAlterar.Text = "ALTERAR";
            this.uiBtnAlterar.TextColor = System.Drawing.Color.White;
            this.uiBtnAlterar.UseVisualStyleBackColor = false;
            this.uiBtnAlterar.Click += new System.EventHandler(this.uiBtnAlterar_Click);
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 237);
            this.Controls.Add(this.uiBtnAlterar);
            this.Controls.Add(this.uiBtnRemover);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiTxtNomeProduto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBarcodeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            this.Load += new System.EventHandler(this.frmGetProduto_Load);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBarcodeProduto;
        private uiCSB.Component.uiTextBox uiTxtNomeProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private uiCSB.Component.uiPanel uiPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private uiCSB.Component.uiButton uiBtnFechar;
        private uiCSB.Component.uiButton uiBtnAdicionar;
        private uiCSB.Component.uiButton uiButton3;
        private uiCSB.Component.uiButton uiBtnRemover;
        private uiCSB.Component.uiButton uiBtnAlterar;
    }
}