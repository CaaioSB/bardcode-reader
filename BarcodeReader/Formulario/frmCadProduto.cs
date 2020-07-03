using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeReader.Common;

namespace BarcodeReader.Formulario
{
    public partial class frmCadProduto : Form
    {
        public frmCadProduto()
        {
            InitializeComponent();
        }

        private void txtBarcodeProduto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Program.produtos.Add(new Objeto
                {
                    Nome = txtNomeProduto.Text,
                    Barcode = txtBarcodeProduto.Text
                });

                this.Close();
            }
        }
    }
}
