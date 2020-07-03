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

namespace BarcodeReader.Formulario
{
    public partial class frmGetProduto : Form
    {
        public frmGetProduto()
        {
            InitializeComponent();
            txtBarcodeProduto.Focus();
        }

        private void cadastarProdutoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCadProduto form = new frmCadProduto();
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
                Objeto objeto = Program.produtos.Where(@object => @object.Barcode == txtBarcodeProduto.Text).FirstOrDefault();

                if (objeto != null)
                {
                    txtNomeProduto.Text = objeto.Nome;
                    txtBarcodeProduto.Focus();

                    Zen.Barcode.Code128BarcodeDraw barcodeDraw = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox1.Image = barcodeDraw.Draw(objeto.Barcode, pictureBox1.Height);
                    txtBarcodeProduto.Text = "";
                }
                else
                {
                    txtNomeProduto.Text = string.Empty;
                    txtBarcodeProduto.Text = string.Empty;
                    pictureBox1.Image = null;
                    txtBarcodeProduto.Focus();
                }
            }
        }
    }
}
