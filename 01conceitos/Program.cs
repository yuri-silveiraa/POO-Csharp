using System;

namespace _01conceitos // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.nome = "Yuri";
            obj.idade = 21;
            obj.mensagem();
        }
    }
}
