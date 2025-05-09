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

            List<Faturamento> diasComFaturamento = modelLogList.Where(m => m.valor > 0).ToList();

            var menor = diasComFaturamento.MinBy(f => f.valor);
            var maior = diasComFaturamento.MaxBy(f => f.valor);

            double media = diasComFaturamento.Average(f => f.valor);
            int diasAcimaMedia = diasComFaturamento.Count(f => f.valor > media);

            return $"Maior faturamento: Dia: {maior.dia}, Valor: {maior.valor},\n" +
                $"Menor faturamento: Dia: {menor.dia}, Valor: {menor.valor},\n" +
                $"Número de dias no mês em que o valor de faturamento diário foi superior à média mensal: {diasAcimaMedia}\n";
            
        }

        private double PercentualEstado(double valor, double total)
        {
            return (valor / total) * 100;
        }

        public string CalculaPercentualEstado()
        {
            double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53;

            double total = SP + RJ + MG + ES + Outros;
            var resultado = $"Percentual de Participacao: SP: {PercentualEstado(SP, total):F2}%," +
                $"RJ: {PercentualEstado(RJ, total):F2}%," +
                $"MG: {PercentualEstado(MG, total):F2}%," +
                $"ES: {PercentualEstado(ES, total):F2}%," +
                $"Outros: {PercentualEstado(Outros, total):F2}%";

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
