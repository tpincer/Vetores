using Oficina.Dominio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Repositorios.SistemaArquivos
{
    public class CorRepositorio
    {
        private string caminhoArquivo = ConfigurationManager.AppSettings["caminhoArquivoCor"];

        public List<Cor> Obter()
        {
            var cores = new List<Cor>();
            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var cor = new Cor {
                    Id = Convert.ToInt32(linha.Substring(0, 5)),
                    Nome = linha.Substring(5)
                };
                cores.Add(cor);
            }
            return cores;
        }

        public Cor Obter(int id)
        {
            Cor cor = null;

            foreach (var linha in File.ReadAllLines(caminhoArquivo))
            {
                var linhaid = Convert.ToInt32(linha.Substring(0, 5));

                if (id == linhaid)
                {
                    cor = new Cor {
                        Id = linhaid,
                        Nome = linha.Substring(5)
                    };

                    break;
                }


            }

            return cor;
        }
    }

}
