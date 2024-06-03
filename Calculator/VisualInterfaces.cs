using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Interfaces
{
    public class VisualInterfaces
    {
        public static void Menu()
        {
            Console.WriteLine(@"
    Bem Vindo a Calculadora!
    
    Digite a Operação que Deseja realizar>>
    
 0 - Encerrar Calculadora");

    Console.WriteLine("\n 1 - Soma\n 2 - Subtração\n 3 - Multiplicação\n 4 - Divisão");
    Console.WriteLine("\n \n Calculadora Científica:\n  5 - Potencia\n  6 - Raiz Quadrada\n  7 - Somatória");

        }

        public static void ParePorUmMomento()
        {
            Console.WriteLine(@"
>>");
            Console.ReadLine();
        }

        public static void Somatoria(int qntSomas)
        {
            Console.WriteLine($"<<Digite o {qntSomas}° Valor da Soma>>");
        }

        public static void SomatoriaComplemento()
        {
            Console.WriteLine("0 Para Parar");
        }

        public static void ResultadoSomatoria(int res, int qntSomas)
        {
            Console.WriteLine(@$"
        O Resultado da Somatória das {qntSomas} Somas, é [{res}]");
            ParePorUmMomento();
        }

        public static void RaizQuadrada()
        {
            Console.WriteLine("<<Digite o Valor do Radicando>>");
            ParePorUmMomento();
        }

        public static void Potencia()
        {
            Console.WriteLine("<<Digite o Valor da ...");
        }

        public static void Generico()
        {
            Console.WriteLine("<<Digite o ...>>");
        }

        public static void ResGenerico(int x, int y, int resultado, string operacao)
        {
            Console.WriteLine("O resultado da operação");
            switch (operacao)
            {
                case "Som":
                    Console.WriteLine($"[{x} + {y} = {resultado}]");
                    ParePorUmMomento();
                break;

                case "Sub":
                    Console.WriteLine($"[{x} - {y} = {resultado}]");
                    ParePorUmMomento();
                break;

                case "Mul":
                    Console.WriteLine($"[{x} * {y} = {resultado}]");
                    ParePorUmMomento();
                break;

                case "Div":
                    Console.WriteLine($"[{x} / {y} = {resultado}]");
                    ParePorUmMomento();
                break;
            }
        }
    }
}