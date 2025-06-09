// Estruturas Condicionais - perguntas

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escolha o exercício para executar:");
        Console.WriteLine("1 - Verificar o menor número");
        Console.WriteLine("2 - Verificar o maior número");
        Console.WriteLine("3 - nível de urgência - chamados");
        Console.Write("Digite o número do exercício: ");
        string escolha = Console.ReadLine();

        switch (escolha)
        {
            case "1":
                Exercicio1.Executar();
                break;
            case "2":
                Exercicio2.Executar();
                break;
            case "3":
                Exercicio3.Executar();
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}

/* 1.Crie um Programa em C# que receba três números do usuário, informe na tela qual
é o MENOR deles ou exiba se eles são iguais. */
public class Exercicio1
{
    public static void Executar()
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("Todos os números são iguais.");
        }
        else
        {
            int menor = num1;
            if (num2 < menor)
                menor = num2;
            if (num3 < menor)
                menor = num3;

            Console.WriteLine($"O menor número é: {menor}");
        }
    }
}

/* 2.Crie um Programa em C# que, receba três números do usuário, informe na tela qual
é o MAIOR deles ou exiba se eles são iguais. */
public class Exercicio2
{
    public static void Executar()
    {
        Console.WriteLine("Digite o primeiro número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o terceiro número:");
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (num1 == num2 && num2 == num3)
        {
            Console.WriteLine("Todos os números são iguais.");
        }
        else
        {
            int maior = num1;
            if (num2 > maior)
                maior = num2;
            if (num3 > maior)
                maior = num3;

            Console.WriteLine($"O maior número é: {maior}");
        }
    }
}

/* 3. Guilherme é chefe do setor de T.I de sua empresa e precisa que você ajude-o a
criar um programa usando a linguagem C# que receba os chamados dos usuários
classificando e exibindo na tela o seu nível de urgência, sendo de 0-3 "BAIXO", maior
que 3 até 6 "MÉDIO", maior que 6 até 9 "ALTO", para os demais casos é considerado
"GRAVE". */

public class Exercicio3
{
    public static void Executar()
    {
        Console.WriteLine("Digite o nível de urgência (0-10):");
        int urgencia = Convert.ToInt32(Console.ReadLine());
        if (urgencia >= 0 && urgencia <= 3)
        {
            Console.WriteLine("Nível de urgência: BAIXO");
        }
        else if (urgencia > 3 && urgencia <= 6)
        {
            Console.WriteLine("Nível de urgência: MÉDIO");
        }
        else if (urgencia > 6 && urgencia <= 9)
        {
            Console.WriteLine("Nível de urgência: ALTO");
        }
        else
        {
            Console.WriteLine("Nível de urgência: GRAVE");
        }
    }
}


