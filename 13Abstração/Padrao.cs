using System;

abstract class Padrao
{

    // Método obrigatorio
    public abstract void taxaEmprestimo(double valor);

    // Método opcional 
    public void calculoPoupanca(double valor, double taxa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$ "+(valor * taxa));
    }

}