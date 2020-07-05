namespace BarcodeReader.Formulario
{
    partial class frmAppend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAppend));
            this.picBarcode = new System.Windows.Forms.PictureBox();
            this.uiPnlHeader = new uiCSB.Component.uiPanel();
            this.uiBtnAjuda = new uiCSB.Component.uiButton();
            this.uiBtnFechar = new uiCSB.Component.uiButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.picHeaderLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.uiBtnCadastrar = new uiCSB.Component.uiButton();
            this.uiTxtBarcode = new uiCSB.Component.uiTextBox();
            this.uiTxtNome = new uiCSB.Component.uiTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).BeginInit();
            this.uiPnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBarcode
            // 
            this.picBarcode.Location = new System.Drawing.Point(12, 106);
            this.picBarcode.Name = "picBarcode";
            this.picBarcode.Size = new System.Drawing.Size(335, 35);
            this.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBarcode.TabIndex = 9;
            this.picBarcode.TabStop = false;
            // 
            // uiPnlHeader
            // 
            this.uiPnlHeader.Controls.Add(this.uiBtnAjuda);
            this.uiPnlHeader.Controls.Add(this.uiBtnFechar);
            this.uiPnlHeader.Controls.Add(this.lblDescription);
            this.uiPnlHeader.Controls.Add(this.picHeaderLogo);
            this.uiPnlHeader.Controls.Add(this.lblTitle);
            this.uiPnlHeader.Draggable = true;
            this.uiPnlHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiPnlHeader.Location = new System.Drawing.Point(-1, -1);
            this.uiPnlHeader.Name = "uiPnlHeader";
            this.uiPnlHeader.PanelColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(74)))), ((int)(((byte)(188)))));
            this.uiPnlHeader.PanelRadius = 0;
            this.uiPnlHeader.Size = new System.Drawing.Size(361, 101);
            this.uiPnlHeader.TabIndex = 1;
            // 
            // uiBtnAjuda
            // 
            this.uiBtnAjuda.BackColor = System.Drawing.Color.Transparent;
            this.uiBtnAjuda.BorderColor = System.Drawing.Color.Transparent;
            this.uiBtnAjuda.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uiBtnAjuda.FlatAppearance.BorderSize = 0;
            this.uiBtnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnAjuda.Location = new System.Drawing.Point(303, 3);
            this.uiBtnAjuda.Name = "uiBtnAjuda";
            this.uiBtnAjuda.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnAjuda.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.uiBtnAjuda.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnAjuda.Size = new System.Drawing.Size(24, 20);
            this.uiBtnAjuda.TabIndex = 2;
            this.uiBtnAjuda.Text = "?";
            this.uiBtnAjuda.TextColor = System.Drawing.Color.White;
            this.uiBtnAjuda.UseVisualStyleBackColor = false;
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
            // 
            // lblDescription
            // 
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(143, 30);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(217, 70);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Cadastrar um objeto a partir de um código de barras.";
            // 
            // picHeaderLogo
            // 
            this.picHeaderLogo.BackColor = System.Drawing.Color.Transparent;
            this.picHeaderLogo.Image = global::BarcodeReader.Properties.Resources.peopleontable;
            this.picHeaderLogo.Location = new System.Drawing.Point(5, 5);
            this.picHeaderLogo.Name = "picHeaderLogo";
            this.picHeaderLogo.Size = new System.Drawing.Size(136, 90);
            this.picHeaderLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHeaderLogo.TabIndex = 1;
            this.picHeaderLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(139, 3);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Barcode";
            // 
            // uiBtnCadastrar
            // 
            this.uiBtnCadastrar.BorderColor = System.Drawing.Color.White;
            this.uiBtnCadastrar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(49)))), ((int)(((byte)(125)))));
            this.uiBtnCadastrar.FlatAppearance.BorderSize = 0;
            this.uiBtnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.uiBtnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.uiBtnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnCadastrar.Location = new System.Drawing.Point(12, 181);
            this.uiBtnCadastrar.Name = "uiBtnCadastrar";
            this.uiBtnCadastrar.OnHoverBorderColor = System.Drawing.Color.White;
            this.uiBtnCadastrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(32)))), ((int)(((byte)(83)))));
            this.uiBtnCadastrar.OnHoverTextColor = System.Drawing.Color.White;
            this.uiBtnCadastrar.Size = new System.Drawing.Size(335, 23);
            this.uiBtnCadastrar.TabIndex = 1;
            this.uiBtnCadastrar.Text = "CADASTRAR OBJETO";
            this.uiBtnCadastrar.TextColor = System.Drawing.Color.White;
            this.uiBtnCadastrar.UseVisualStyleBackColor = true;
            this.uiBtnCadastrar.Click += new System.EventHandler(this.uiBtnCadastrar_Click);
            // 
            // uiTxtBarcode
            // 
            this.uiTxtBarcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.uiTxtBarcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxtBarcode.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.uiTxtBarcode.ForeColor = System.Drawing.Color.White;
            this.uiTxtBarcode.Location = new System.Drawing.Point(12, 108);
            this.uiTxtBarcode.Name = "uiTxtBarcode";
            this.uiTxtBarcode.Size = new System.Drawing.Size(19, 26);
            this.uiTxtBarcode.TabIndex = 1;
            this.uiTxtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTxtBarcode.ValidadeType = uiCSB.Component.uiTextBox.Validate.None;
            this.uiTxtBarcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uiTxtBarcode_KeyUp);
            // 
            // uiTxtNome
            // 
            this.uiTxtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(73)))), ((int)(((byte)(80)))));
            this.uiTxtNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiTxtNome.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.uiTxtNome.ForeColor = System.Drawing.Color.White;
            this.uiTxtNome.Location = new System.Drawing.Point(12, 147);
            this.uiTxtNome.Name = "uiTxtNome";
            this.uiTxtNome.Size = new System.Drawing.Size(335, 26);
            this.uiTxtNome.TabIndex = 2;
            this.uiTxtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiTxtNome.ValidadeType = uiCSB.Component.uiTextBox.Validate.None;
            this.uiTxtNome.Click += new System.EventHandler(this.uiTxtNome_Click);
            this.uiTxtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.uiTxtNome_KeyUp);
            // 
            // frmAppend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(359, 214);
            this.Controls.Add(this.picBarcode);
            this.Controls.Add(this.uiTxtNome);
            this.Controls.Add(this.uiTxtBarcode);
            this.Controls.Add(this.uiBtnCadastrar);
            this.Controls.Add(this.uiPnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAppend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode Reader";
            ((System.ComponentModel.ISupportInitialize)(this.picBarcode)).EndInit();
            this.uiPnlHeader.ResumeLayout(false);
            this.uiPnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeaderLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private uiCSB.Component.uiPanel uiPnlHeader;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        
        private System.Windows.Forms.PictureBox picBarcode;
        private System.Windows.Forms.PictureBox picHeaderLogo;
        
        private uiCSB.Component.uiButton uiBtnFechar;
        private uiCSB.Component.uiButton uiBtnAjuda;
        private uiCSB.Component.uiButton uiBtnCadastrar;
        private uiCSB.Component.uiTextBox uiTxtBarcode;
        private uiCSB.Component.uiTextBox uiTxtNome;
    }
}