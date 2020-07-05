using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeReader.Common;
using uiCSB.Toastr;
using uiCSB.Util;

namespace BarcodeReader.Formulario
{
    public partial class frmAppend : Form
    {
        public frmAppend()
        {
            InitializeComponent();
            new RoundedForm(this);
        }

        private void uiTxtBarcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                picBarcode.Image = barcodeDraw.Draw(uiTxtBarcode.Text, picBarcode.Height);

                uiTxtNome.Focus();
            }
        }

        private void uiTxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                // Cadastra o objeto
                bool objetoInserted = new Objeto
                {
                    Nome = uiTxtNome.Text,
                    Barcode = uiTxtBarcode.Text
                }.InserirObjeto();

                if (objetoInserted)
                {
                    new Alert("O objeto foi cadastrado!", uiCSB.Toastr.Type.Success);

                    this.Hide();
                    var frmReader = new frmReader();
                    frmReader.Closed += (s, args) => this.Close();
                    frmReader.Show();
                }

                uiTxtNome.Text = string.Empty;
                uiTxtBarcode.Text = string.Empty;
                picBarcode.Image = null;
                uiTxtBarcode.Focus();
            }
        }

        private void uiBtnCadastrar_Click(object sender, EventArgs e)
        {
            // Cadastra o objeto
            bool objetoInserted = new Objeto
            {
                Nome = uiTxtNome.Text,
                Barcode = uiTxtBarcode.Text
            }.InserirObjeto();

            if (objetoInserted)
            {

                new Alert("O objeto foi cadastrado!", uiCSB.Toastr.Type.Success);

                this.Hide();
                var frmReader = new frmReader();
                frmReader.Closed += (s, args) => this.Close();
                frmReader.Show();
            }

            uiTxtNome.Text = string.Empty;
            uiTxtBarcode.Text = string.Empty;
            picBarcode.Image = null;
            uiTxtBarcode.Focus();
        }

        private void uiTxtNome_Click(object sender, EventArgs e)
        {
            uiTxtBarcode.Focus();
        }
    }
}
