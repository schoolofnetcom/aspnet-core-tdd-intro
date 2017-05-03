using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCoreTDD.Tests
{
    [TestClass]
    public class FibonacciTest
    {
        //POSIÇÃO   0   1   2   3   4   5   6   7   8   9   10  ...
        //NUMERO    0   1   1   2   3   5   8   13  21  34  55  ...

        [TestMethod]
        public void PrimeiroElementoDeveSerZero()
        {
            var resultado = Fibonacci.ObterElemento(0);
            Assert.AreEqual(resultado, 0, "Valor náo é zero.");
        }

        [TestMethod]
        public void SegundoElementoDeveSerUm()
        {
            var resultado = Fibonacci.ObterElemento(1);
            Assert.AreEqual(resultado, 1, "Valor náo é um.");
        }

        [TestMethod]
        public void SextoElementoDeveSerCinco()
        {
            var resultado = Fibonacci.ObterElemento(5);
            Assert.AreEqual(resultado, 5, "Valor náo é cinco.");
        }

        [TestMethod]
        public void NonoElementoDeveSer34()
        {
            var resultado = Fibonacci.ObterElemento(9);
            Assert.AreEqual(resultado, 34, "Valor náo é 34.");
        }
    }

    public static class Fibonacci
    {
        public static int ObterElemento(int posicao)
        {
            if (posicao < 0) throw new Exception("Posição não pode ser menor que zero.");
            if (posicao < 2) return posicao;
            return ObterElemento(posicao -1) + ObterElemento(posicao -2);
        }
    }
}
