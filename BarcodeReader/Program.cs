using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BarcodeReader.Common;
using BarcodeReader.Formulario;

namespace BarcodeReader
{
    static class Program
    {
        public static List<Objeto> produtos = new List<Objeto>();

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGetProduto());
        }
    }
}
