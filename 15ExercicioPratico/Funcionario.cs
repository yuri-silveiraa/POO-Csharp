using System;

class Funcionario
{
    // Atributo
    public string nome;
    public int horas;
    public double valorHora;
    public string terceirizado;
    public double salario;
    public double adicional;

    // Construtor
    public Funcionario(string terceirizado, string nome, int horas, double valorHora, double adicional)
    {
        this.terceirizado = terceirizado;
        this.nome = nome;
        this.horas = horas;
        this.valorHora = valorHora;
        this.adicional = adicional;
        if (terceirizado == "sim")
        {
            this.salario = (horas * valorHora) + adicional * 1.1;
        }
        else if (terceirizado == "nao")
        {
            this.salario = (horas * valorHora);
        }      
    }

    public Funcionario(string terceirizado, string nome, int horas, double valorHora)
    {
        this.terceirizado = terceirizado;
        this.nome = nome;
        this.horas = horas;
        this.valorHora = valorHora;
        this.salario = horas * valorHora;

    }
}