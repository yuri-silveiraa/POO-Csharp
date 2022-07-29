using System;

class Aluno
{
    // Atributos
    private double nota1, nota2;

    // Média
    private double media()
    {
        return (nota1 + nota2)/2;
    }

    //Mensagem 
    public void mensagem()
    {
        Console.WriteLine("Informe a primeira nota 1");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe a segunda nota 2");
        nota2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("A média é "+media());
    }
}