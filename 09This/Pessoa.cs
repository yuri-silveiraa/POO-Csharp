using System;

class Pessoa 
{
    // Atributo
    private string nome = "Amanda";

    // Construtor
    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}