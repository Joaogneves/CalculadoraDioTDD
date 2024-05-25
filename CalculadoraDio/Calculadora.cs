using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDio
{
    public class Calculadora
    {
        private Queue<string> historico;
        private string data;

        public Calculadora(string data)
        {
            historico = new Queue<string>();
            this.data = data;
        }

        public int Somar(int num1, int num2)
        {
            int resultado = num1 + num2;
            AddHistorico("+", num1, num2, resultado);
            return resultado;
        }

        public int Subtrair(int num1, int num2)
        {
            int resultado = num1 - num2;
            AddHistorico("-", num1, num2, resultado);
            return resultado;
        }

        public int Multuplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            AddHistorico("*", num1, num2, resultado);
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            AddHistorico("+", num1, num2, resultado);
            return resultado;
        }

        public List<string> Historico()
        {
            List<string> list = new();
            foreach (string item in historico)
            {
                list.Add(item);
            }
            return list;
        }

        public void AddHistorico(string operador, int num1, int num2, int resultado)
        {
            if (historico.Count == 3)
                historico.Dequeue();
            historico.Enqueue($"{num1} {operador} {num2} = {resultado} -- {this.data}");
        }
    }
}
