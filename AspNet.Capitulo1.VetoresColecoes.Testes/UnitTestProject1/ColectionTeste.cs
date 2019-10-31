using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColectionTeste {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void ListTeste() {
            var inteiros = new List<int>(1000) { 16, 3, 2, -81 };
            inteiros.Add(15);
            inteiros[0] = 23;

            var maisInteiros = new List<int> { 4, 2, 3 };

            inteiros.AddRange(maisInteiros);
            inteiros.Insert(0, 29);
            inteiros.Remove(2);
            inteiros.RemoveAll(x=> x == 2);
            inteiros.RemoveAt(4);
            inteiros.Sort();

            var primeiro = inteiros[0];
            primeiro = inteiros.First();

            var ultimo = inteiros.Last();
            ultimo = inteiros[inteiros.Count - 1];

            foreach (var inteiro in inteiros) {
                Console.WriteLine($"(inteiros.IndexOf(inteiro)):(inteiro)");
            }

      
        }

        [TestMethod]
        public void DictionaryTeste()
        {
            var feriados = new Dictionary<DateTime, string>();

            feriados.Add(new DateTime(2019,11,2),"Finados");
            feriados.Add(Convert.ToDateTime("2019/11/15"), "Proclamação da República");
            feriados.Add(Convert.ToDateTime("2019/11/20"), "Consciência Negra");

            var finados = feriados[new DateTime(2019, 11, 2)];

            foreach (var feriado in feriados)
            {
                Console.WriteLine($"{feriado.Key.ToString("dd/MM/yyyy")}:{feriado.Value}");


                Console.ReadLine();
            }
            
        }
    }

}
