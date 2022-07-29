using System;

class Atendente : Imposto
{
    
    // Método 
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Atendente salariodo vale alimentação R$"+(salario * 0.12));
    }

}