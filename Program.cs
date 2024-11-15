using System;

public class idadecivil
{
    public static void Main(string[] args)
    {
    int idade = 25;
    bool isCasado = true;

        if (idade < 18)
        {
            Console.WriteLine("é menor de idade");
        }
        else if  (idade >= 18 && idade < 65 && isCasado)
        {
            Console.WriteLine("é casado e é adulto");
        }
        else if (idade >= 18 && !isCasado)
        {
            Console.WriteLine("é solteiro e é adulto");
        }
        else
        {
            Console.WriteLine("é um senhor");
        }  
    }
}