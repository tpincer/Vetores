using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AspNet.Capitulo1.VetoresColecoes.Testes {
    [TestClass]
    public class VetoresTest {
        [TestMethod]
        public void InicializacaoTeste() {
            var inteiros = new int[5];
            inteiros[0] = 48;
            inteiros[1] = 20;
            //inteiros[-5] = 8;

            var decimais = new decimal[] { 0.2m, 5, 2.52m, 1.9m };

            decimal[] maisDecimais = { 2, 5.8m, 0.5m };
            foreach (var @decimal in decimais) {
                Console.WriteLine(@decimal);
            }

            Console.WriteLine($"O tamanho do vetor {nameof(decimais)} é:{decimais.Length }");


        }


        [TestMethod]
        public void RedimensionamentoTeste() {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };

            Array.Resize(ref decimais, 5);

            decimais[3] = 1.7m;

            decimais[3] = 1.7m;
            Assert.AreEqual(decimais[4], 0m);
        }

        [TestMethod]
        public void OrdenacaoTeste() {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };
            Array.Sort(decimais);
            Assert.AreEqual(decimais[0], -8m);
        }

        [TestMethod]
        public void ParamsTeste() {
            var decimais = new decimal[] { 2.1m, 1.6m, -8 };
            Console.WriteLine(Media(decimais));
            Console.WriteLine(Media(1.9m,2.1m,22,0.3m));
            Console.WriteLine(decimais.Average());

        }

        private decimal Media(decimal valor1, decimal valor2) {
            return (valor1 + valor2) / 2;
        }

        private decimal Media(params decimal[] valores) {
            var soma = 0m;
            foreach (var valor in valores) {
                soma += valor;
            }
            //for (int i = 0; i < valores.Length; i++) {
            //    soma += valores[i];
            //}

            return soma / valores.Length;
        }

        [TestMethod]
        public void TodaStringEhUmVetorTeste() {
            var nome = "Vitor";

            Assert.AreEqual(nome[0], 'V');
            foreach (var letra in nome) {
                Console.Write(letra);
            }
        }


    }
}






