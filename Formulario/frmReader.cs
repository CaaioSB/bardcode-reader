using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeReader.Common;
using uiCSB.Util;

namespace BarcodeReader.Formulario
{
    public partial class frmReader : Form
    {
        Objeto objetoAtual;

        public frmReader()
        {
            InitializeComponent();
            new RoundedForm(this);
            txtBarcodeProduto.Focus();
        }

        private void cadastarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAppend form = new frmAppend();
            form.ShowDialog();
            txtBarcodeProduto.Focus();
        }

        private void frmGetProduto_Load(object sender, EventArgs e)
        {
            txtBarcodeProduto.Focus();
        }

        private void txtBarcodeProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Objeto objeto = new Objeto
                {
                    Barcode = txtBarcodeProduto.Text
                }.ObterObjeto();

                if (objeto != null)
                {
                    uiTxtNomeProduto.Text = objeto.Nome;
                    txtBarcodeProduto.Focus();

                    Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox1.Image = barcodeDraw.Draw(objeto.Barcode, pictureBox1.Height);

                    objetoAtual = new Objeto
                    {
                        Nome = objeto.Nome,
                        Barcode = objeto.Barcode
                    };

                    txtBarcodeProduto.Text = "";
                }
                else
                {
                    uiTxtNomeProduto.Text = string.Empty;
                    txtBarcodeProduto.Text = string.Empty;
                    pictureBox1.Image = null;
                    txtBarcodeProduto.Focus();
                }
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiBtnAdicionar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmAppend = new frmAppend();
            frmAppend.Closed += (s, args) => this.Close();
            frmAppend.Show();
        }

        private void uiBtnAlterar_Click(object sender, EventArgs e)
        {
            new Objeto
            {
                Nome = uiTxtNomeProduto.Text,
                Barcode = objetoAtual.Barcode
            }.AlterarObjeto();

            txtBarcodeProduto.Focus();
        }

        private void uiBtnRemover_Click(object sender, EventArgs e)
        {
            if (objetoAtual.RemoverObjeto())
            {
                txtBarcodeProduto.Text = "";
                uiTxtNomeProduto.Text = "";
            }
            txtBarcodeProduto.Focus();
        }
    }
}
