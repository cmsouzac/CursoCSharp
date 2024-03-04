using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev.Basico
{
    public class VarCont
    {
        public static void VariaveisConst()
        {
            int idade = 0; //Correto inicia com ZERO
            int idade2 = 25; //Correto inicia com 25
            var idade3 = 25; //Correto inicia com 25
            //var idade4; //Errado
            Console.WriteLine(idade);
        }

        public static void VariaveisConst2()
        {
            //area da circuferencia
            double raio = 4.5;
            const double PI = 3.14;
            //PI = 3.1415; nao podemos modificar uma const.

            raio = 5.5;

            double area = PI * raio * raio;
            Console.WriteLine("Área é " + area + 1000);

            //Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salário " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor int " + menorValorInt);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("Tamanho da população Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            float precoComputador = 1299.99f; //
            Console.WriteLine("O Preço do Computador " + precoComputador);

            ulong populacaoMundial = 8_000_000;
            string populacaoFormatada = $"{populacaoMundial:N0}";
            Console.WriteLine("População Mundial: " + populacaoFormatada);

            double valorDeMercadoDaApple = 1_000_000_000_00.00;
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre Estrelas " + distanciaEntreEstrelas);

            char letra = 'A';
            Console.WriteLine("Letra " + letra);

            string texto = "Seja bem vindo ao curso de C#!";
            Console.WriteLine(texto);

        }
    }
}
