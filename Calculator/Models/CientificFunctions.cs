using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculator.Interfaces;
using Calculator.Models;

namespace Calculator.Models
{
    public class CientificFunctions
    {
        public static void Somatoria()
        {
            BasicFunctions S = new BasicFunctions();
            bool enabled = true;
            int somaBuffer;
            int SomaAcumulada = 0;
            int count = 0;
            while (enabled)
            {
                count++;
                try
                {
                    VisualInterfaces.Somatoria(count);
                    if (count > 1)
                    { 
                        VisualInterfaces.SomatoriaComplemento(); 
                    }
                    somaBuffer = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    throw new ArgumentException("Valor Inválido");
                }

                if (somaBuffer == 0) 
                {
                    VisualInterfaces.ResultadoSomatoria(SomaAcumulada, count - 1); 
                    enabled = false; 
                }

                SomaAcumulada = S.Som(somaBuffer, SomaAcumulada);
                Console.WriteLine($"\n{count}° - Soma Acumulada>> " + SomaAcumulada);
                Console.WriteLine("");
            }
        }

        public double Potencia(double Base, double Expoente)
        {
            return Math.Pow(Base, Expoente);
        }

        public double RaizQuadrada(double Radicando)
        {
            return Math.Sqrt(Radicando);
        }
    }
}