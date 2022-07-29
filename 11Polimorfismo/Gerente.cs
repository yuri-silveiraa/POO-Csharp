using System;

class Gerente : Imposto
{
    
    // Método 
    public override void valeAlimentacao(double salario)
    {
        Console.WriteLine("Desconto Gerente do vale alimentação R$"+(salario * 0.15));
    }
}