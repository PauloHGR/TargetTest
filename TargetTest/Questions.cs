using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TargetTest
{
    public class Questions
    {
        public string ImprimeSoma()
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                soma += k;
                k++;
            }

            return $"Questao 01: A soma dos números de 0 a {indice} é: {soma}";
        }

        public string CalculaFibonacci(int value)
        {
            int a = 0, b = 1;

            while (a <= value)
            {

                if(a == value)
                {
                    return $"O número {value} pertence à sequência de Fibonacci.";
                }
                int anterior = a;
                a = b;
                b = anterior + b;

            }

            return $"O número {value} não pertence à sequência de Fibonacci.";
        }

        public string Question03()
        {
            string json = File.ReadAllText("C:\\Users\\paulo\\source\\repos\\TargetTest\\TargetTest\\dados.json");

            List<Faturamento> modelLogList = JsonSerializer.Deserialize<List<Faturamento>>(json);
            Faturamento menor = modelLogList[0];
            Faturamento maior = modelLogList[0];
            
            foreach (var modelLog in modelLogList)
            {
                if ( modelLog.valor > maior.valor)
                {
                    maior = modelLog;
                }

                if (modelLog.valor < menor.valor)
                {
                    menor = modelLog;
                }

            }

            List<Faturamento> diasComFaturamento = modelLogList.Where(m => m.valor > 0).ToList();
            double soma = 0;
            double media = 0;
            foreach (var item in diasComFaturamento)
            {
                soma += item.valor;
            }
            media = soma / diasComFaturamento.Count;
            int diasAcimaMedia = 0;
            foreach (var item in diasComFaturamento)
            {
                if (item.valor > media)
                {
                    diasAcimaMedia++;
                }
            }
            return $"Maior faturamento: Dia: {maior.dia}, Valor: {maior.valor}," +
                $"Menor faturamento: Dia: {menor.dia}, Valor: {menor.valor}," +
                $"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: {diasAcimaMedia}";
            
        }

        private double PercentualEstado(double valor, double total)
        {
            return (valor / total) * 100;
        }

        public string CalculaPercentualEstado()
        {
            double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53;

            double total = SP + RJ + MG + ES + Outros;
            var resultado = $"Percentual de Participacao: SP: {PercentualEstado(SP, total)}%," +
                $"RJ: {PercentualEstado(RJ, total)}%," +
                $"MG: {PercentualEstado(MG, total)}%," +
                $"ES: {PercentualEstado(ES, total)}%," +
                $"Outros: {PercentualEstado(Outros, total)}%";

            return resultado;
        }

        public string InverteString(string value)
        {
            string newString = "";

            for (int i = value.Length-1; i >= 0; i--)
            {
                newString += value[i];
            }

            return newString;
        }
    }
}
