using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BarcodeReader.Common;
using BarcodeReader.Formulario;
using uiCSB.Toastr;

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
            try
            {
                if (!App.CreateDirectory())
                {
                    new Alert("O directório da aplicação não existe, tente reiniciar a aplicação.", uiCSB.Toastr.Type.Warning);
                }
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, uiCSB.Toastr.Type.Warning);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmReader());
        }
    }
}
