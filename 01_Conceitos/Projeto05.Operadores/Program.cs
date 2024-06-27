using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto05.Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador de Divisao Inteira
            Console.Write("Informe um número inteiro: ");
            //int.Parse convert string para inteiro.
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Informe um número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            /*  / = divisao
                + = soma
                - = diminui
                * = multiplicação
                % = módulo (resto da divisao)
            */

            //retorno inteiro
            //double resultado = n1 / n2;

            //retorno decimais
            double resultado = (double)n1 / n2;

            //resto da divisao
            //resto da divisao de n1 por n2.
            int resto = n1 % n2;

            Console.Write($"Divisão inteira: {resultado}");
            Console.Write($"Resto da divisao inteira: {resto}");
            Console.ReadKey();



        }
    }
}
