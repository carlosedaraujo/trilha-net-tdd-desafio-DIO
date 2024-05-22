using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        private List<string> listadehistorico;
        private string data;

        public CalculadoraImp(string data)
        {
            listadehistorico = new List<string>();
            this.data = data;

        }
        public int somar(int num1, int num2)
        {
            int operacao = num1 + num2;

            listadehistorico.Insert(0, "Res: " +  operacao + " - data:" + data);

            return operacao;
        }

        public int subtrair(int num1, int num2)
        {
            int operacao = num1 - num2;

            listadehistorico.Insert(0, "Res: " + operacao + " - data:" + data);

            return operacao;
        }

        public int multiplicar(int num1, int num2)
        {
            int operacao = num1 * num2;

            listadehistorico.Insert(0, "Res: " + operacao + " - data:" + data);

            return operacao;
        }

        public int dividir(int num1, int num2)
        {
            int operacao = num1 / num2;

            listadehistorico.Insert(0, "Res: " + operacao + " - data:" + data);

            return operacao;
        }

        public List<string> historico()
        {
            listadehistorico.RemoveRange(3, listadehistorico.Count - 3);
            
            return listadehistorico;
        }

    }
}
