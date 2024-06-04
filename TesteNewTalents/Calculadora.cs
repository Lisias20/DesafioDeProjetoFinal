using System;
using System.Collections.Generic;
using System.Text;

namespace TesteNewTalents
{
    public class Calculadora
    {
        private List<string> ListaHistorico;
        private string data;
        public Calculadora(string data)
        {
            ListaHistorico = new List<string>();
            this.data = data;
        }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            ListaHistorico.Insert(0, "res: " + res + " -data: " + data);
            return res;
        }


        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            ListaHistorico.Insert(0, "res: " + res + " -data: " + data);
            return res;
        }


        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            ListaHistorico.Insert(0, "res: " + res + " -data: " + data);
            return res;
        }


        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            ListaHistorico.Insert(0, "res: " + res + " -data: " + data);
            return res;
        }

        public List<string> historico()
        {
            ListaHistorico.RemoveRange(3, ListaHistorico.Count -3);

            return ListaHistorico;
        }
    }
}
