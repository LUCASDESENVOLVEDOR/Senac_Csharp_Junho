using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto06.OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar a idade de uma pessoa.
            Console.Write("Informe sua idade");
            int idade = int.Parse(Console.ReadLine());

            //if ternario
            //idade < 18 condicao ?
            //"Menor Idade" - (true)
            //"Maior de Idade" - (false)

            string resposta = idade < 18 ?
                "Menor Idade" : "Maior de Idade";

            Console.WriteLine($"Você é {resposta}");
            Console.WriteLine(); //linha em branco.

            //Verificar se o ano é bissexto
            Console.Write("Informe um ano");
            //Dias em fevereiro.
            //se a divisao do ano por 4 o
            //resto for 0 entao o  ano é
            // bissexto;
            int ano = int.Parse(Console.ReadLine());
            //Calcular dias de feveiro baseando-se
            //se o ano é bissexto.
            int diasFevereiro 
                = (ano % 4) == 0 ? 29 : 28;

            Console.WriteLine($"O ano {ano}" +
                $"possui {diasFevereiro} dias em" +
                $"fevereiro");







            Console.ReadKey();
        }
    }
}
