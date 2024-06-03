using Calculator.Interfaces;
using Calculator.Models;

namespace Calculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BasicFunctions B = new BasicFunctions();
            CientificFunctions C = new CientificFunctions();
            bool enabled = true;

            while (enabled)
            {
                Console.Clear();
                VisualInterfaces.Menu();

                string menu = Console.ReadLine();

                try
                {
                    switch (menu)
                    {
                        case "1":
                        VisualInterfaces.Generico();
                        try
                        {
                            Console.WriteLine("1° Valor>>");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("2° Valor>>");
                            int y = int.Parse(Console.ReadLine());

                            Console.WriteLine($"[{x} + {y} = " + B.Som(x, y) + "]");
                            VisualInterfaces.ParePorUmMomento();
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("<<<Não é possível somar este valor!>>>");
                        }
                        break;

                        case "2":
                        VisualInterfaces.Generico();
                        try
                        {
                            Console.WriteLine("1° Valor>>");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("2° Valor>>");
                            int y = int.Parse(Console.ReadLine());

                            Console.WriteLine($"[{x} - {y} = " + B.Sub(x, y) + "]");
                            VisualInterfaces.ParePorUmMomento();
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("<<<Não é possível subtrair este valor!>>>");
                        }
                        break;

                        case "3":
                        VisualInterfaces.Generico();
                        try
                        {
                            Console.WriteLine("1° Valor>>");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("2° Valor>>");
                            int y = int.Parse(Console.ReadLine());

                            Console.WriteLine($"[{x} * {y} = " + B.Mul(x, y) + "]");
                            VisualInterfaces.ParePorUmMomento();
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("<<<Não é possível multiplicar este valor!>>>");
                        }
                        break;

                        case "4":
                        VisualInterfaces.Generico();
                        try
                        {
                            Console.WriteLine("1° Valor>>");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("2° Valor>>");
                            int y = int.Parse(Console.ReadLine());

                            Console.WriteLine($"[{x} / {y} = " + B.Div(x, y) + "]");
                            VisualInterfaces.ParePorUmMomento();
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("<<<Não é possível dividir este valor!>>>");
                        }
                        break;

                        case "5":
                        VisualInterfaces.Generico();
                        try
                        {
                            Console.WriteLine("Valor da Base>>");
                            int x = int.Parse(Console.ReadLine());
                            Console.WriteLine("Valor do Expoente>>");
                            int y = int.Parse(Console.ReadLine());

                            Console.WriteLine($"[{x} ^ {y} = " + C.Potencia(x, y) + "]");
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("<<<Não é possível Potencializar este valor!>>>");
                        }
                        break;

                        case "6":
                        VisualInterfaces.Generico();
                        try
                        {
                            Console.WriteLine("Valor do Radicando>>");
                            int x = int.Parse(Console.ReadLine());

                            Console.WriteLine($"[√{x} = " + C.RaizQuadrada(x) + "]");
                            VisualInterfaces.ParePorUmMomento();
                            
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException("<<<Não é possível Extraír a Raiz Quadrada deste valor!>>>");
                        }
                        break;

                        case "7":
                        CientificFunctions.Somatoria();
                        break;

                        case "0":
                        Console.WriteLine("Finalizando Calculadora>>");
                        enabled = false;
                        break;

                        default:
                        break;
                    }
                }
                catch (Exception)
                {
                    throw new ArgumentException("Valor Inválido!");
                }
            }
        }
    }
}