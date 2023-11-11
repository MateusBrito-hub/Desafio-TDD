using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_TDD
{
    public class Calculadora
    {
        private List<string?> historicoList;
        private DateTime date = DateTime.Now;

        public Calculadora(DateTime date)
        {
            historicoList = new List<string>();
            this.date = date;
        }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            historicoList.Insert(0,$"{date}: A soma de {val1} + {val2} é = {res}");
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            historicoList.Insert(0, $"{date}: A subtração de {val1} - {val2} é = {res}");
            return res;
        }

        public int multiplicar(int val1, int val2)
        {
            int res = val1 * val2;
            historicoList.Insert(0, $"{date}: A multiplicação de {val1} x {val2} é = {res}");
            return res;
        }

        public int dividir(int val1, int val2)
        {
            int res = val1 / val2;
            historicoList.Insert(0, $"{date}: A divisão de {val1} / {val2} é = {res}");
            return res;
        }

        public List<string?> historico()
        {
            historicoList.RemoveRange(3, historicoList.Count - 3);
            return historicoList;
        }
    }
}
