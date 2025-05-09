// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.Serialization;
using System.Text.Json;
using TargetTest;

namespace HelloWorld;

public class Program
{
    
    public static void Main(string[] args)
    {

        var questions = new Questions();
        Console.WriteLine("Questao 01: " + questions.ImprimeSoma());
        Console.WriteLine("Questao 02: " + questions.CalculaFibonacci(34));
        Console.WriteLine("Questao 03: " + questions.Question03());
        Console.WriteLine("Questao 04: " + questions.CalculaPercentualEstado() + '\n');
        Console.WriteLine("Questao 05: " + questions.InverteString("Melancia") + '\n');
    }
}
