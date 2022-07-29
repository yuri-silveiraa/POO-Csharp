using System;

class Pessoa 
{
    public double altura, peso;

    //IMC
    public double IMC()
    {
        return peso/(altura * altura);
    }

    // Situação
    public string situacao(double IMC)
    {
        // Variável
        string retorno;

        // Condicionais
        if(IMC < 18.5)
        {
            retorno = "Abaixo do peso";
        } 
        else if(IMC <25)
        {
            retorno = "Peso normal";
        }
        else if(IMC <30)
        {
            retorno = "Acima do peso";
        }
        else if(IMC <35)
        {
            retorno = "Obesidade I";
        }
        else if(IMC <40)
        {
            retorno = "Obesidade II";
        }
        else
        {
            retorno = "Obesidade III";
        }
        return retorno;
    }

    // Mensagem
    public void mensagem()
    {
        double obterIMC = IMC();

        string obterSituacao = situacao(obterIMC);

        Console.WriteLine("Seu IMC é "+obterIMC+" sua situação atual é "+obterSituacao); 
    }
}