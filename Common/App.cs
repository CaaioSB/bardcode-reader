using System;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace BarcodeReader.Common
{
    public static class App
    {
        private static readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + string.Format(@"\{0}\{1}", "BarcodeReader", "Objeto");
        private static readonly string objetoPath = Path + @"\Objetos";
        private static readonly string objetoJson = ObjetoPath + @"\objetos.json";

        public static string Path => path;

        public static string ObjetoPath => objetoPath;

        public static string ObjetoJson => objetoJson;

        /// <summary>
        /// Cria o directório padrão da aplicação caso não exista.
        /// </summary>
        /// <returns></returns>
        public static bool CreateDirectory()
        {
            if (!Directory.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            return Directory.Exists(path);
        }

        /// <summary>
        /// Cria o directório que armanezará um arquivo .json no qual conterá os objetos cadastrados.
        /// </summary>
        /// <returns></returns>
        public static bool CreateObjetoDirectory()
        {
            if (!Directory.Exists(ObjetoPath))
            {
                Directory.CreateDirectory(ObjetoPath);
            }

            return Directory.Exists(ObjetoPath);
        }

        /// <summary>
        /// Cria o arquivo .json que armazenará os objetos cadastrados.
        /// </summary>
        /// <returns></returns>
        public static bool ObjetoJsonExists()
        {
            if (CreateDirectory())
            {
                if (CreateObjetoDirectory())
                {
                    return File.Exists(ObjetoJson);
                }
            }

            return false;
        }
    }
}
