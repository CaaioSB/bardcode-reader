using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using uiCSB.Toastr;

namespace BarcodeReader.Common
{
    public class Objeto
    {
        private string barcode;
        private string nome;

        public string Nome { get => nome; set => nome = value; }
        public string Barcode { get => barcode; set => barcode = value; }

        public List<Objeto> ObterObjetos()
        {
            string objetoJson = File.ReadAllText(App.ObjetoJson);

            List<Objeto> objeto = JsonConvert.DeserializeObject<List<Objeto>>(objetoJson);
            return objeto;
        }

        public Objeto ObterObjeto()
        {
            try
            {
                string objetoJson = File.ReadAllText(App.ObjetoJson);
                List<Objeto> listObjetos = JsonConvert.DeserializeObject<List<Objeto>>(objetoJson);
                Objeto objeto = listObjetos.Single(listObjeto => listObjeto.Barcode == Barcode);

                return objeto;
            }
            catch (DirectoryNotFoundException)
            {
                new Alert("Você ainda não possui nenhum produto cadastrado.", uiCSB.Toastr.Type.Warning);
            }
            catch (InvalidOperationException)
            {
                new Alert("Este produto não foi encontrado, tente cadastrá-lo.", uiCSB.Toastr.Type.Warning);
            }
            catch (Exception ex)
            {
                new Alert(ex.Message, uiCSB.Toastr.Type.Error);
            }

            return null;
        }

        public bool InserirObjeto()
        {
            if (ObjetoJsonExists())
            {
                List<Objeto> objetos = ObterObjetos();
                bool objetoExist = objetos.Any(objeto => objeto.Barcode == barcode);

                objetos.Add(new Objeto
                {
                    Nome = nome,
                    Barcode = barcode
                });

                if (!objetoExist)
                {
                    File.Delete(App.ObjetoJson);
                    if (!ObjetoJsonExists())
                    {
                        using (StreamWriter writer = new StreamWriter(App.ObjetoJson))
                        {
                            writer.Write(JsonConvert.SerializeObject(objetos));
                        }

                        return true;
                    }
                }
                else
                {
                    new Alert("Este produto já foi cadastrado anteriormente.", uiCSB.Toastr.Type.Warning);
                }
            }
            else
            {
                List<Objeto> objetos = new List<Objeto>();

                objetos.Add(new Objeto
                {
                    Nome = nome,
                    Barcode = barcode
                });

                using (StreamWriter writer = new StreamWriter(App.ObjetoJson))
                {
                    writer.Write(JsonConvert.SerializeObject(objetos));
                }

                return true;
            }

            return false;
        }

        public bool RemoverObjeto()
        {
            try
            {
                List<Objeto> objetos = ObterObjetos();
                objetos.RemoveAll(objeto => objeto.Barcode == barcode);

                File.Delete(App.ObjetoJson);
                using (StreamWriter writer = new StreamWriter(App.ObjetoJson))
                {
                    writer.Write(JsonConvert.SerializeObject(objetos));
                }

                new Alert("O objeto foi removido.", uiCSB.Toastr.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                new Alert("Erro ao remover o objeto.\n" + ex.Message, uiCSB.Toastr.Type.Error);
                return false;
            }
        }

        public bool AlterarObjeto()
        {
            try
            {
                List<Objeto> objetos = ObterObjetos();
                objetos.RemoveAll(objeto => objeto.Barcode == barcode);
                objetos.Add(new Objeto
                {
                    Nome = nome,
                    Barcode = barcode
                });

                File.Delete(App.ObjetoJson);
                using (StreamWriter writer = new StreamWriter(App.ObjetoJson))
                {
                    writer.Write(JsonConvert.SerializeObject(objetos));
                }

                new Alert("O objeto foi alterado.", uiCSB.Toastr.Type.Success);
                return true;
            }
            catch (Exception ex)
            {
                new Alert("Erro ao alterar o objeto.\n" + ex.Message, uiCSB.Toastr.Type.Error);
                return false;
            }
        }

        public static bool ObjetoJsonExists()
        {
            if (App.CreateDirectory())
            {
                if (App.CreateObjetoDirectory())
                {
                    return File.Exists(App.ObjetoJson);
                }
            }

            return false;
        }
    }
}
