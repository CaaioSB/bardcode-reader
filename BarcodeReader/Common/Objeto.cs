using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeReader.Common
{
    public class Objeto
    {
        private string barcode;
        private string nome;

        public string Nome { get => nome; set => nome = value; }
        public string Barcode { get => barcode; set => barcode = value; }
    }
}
