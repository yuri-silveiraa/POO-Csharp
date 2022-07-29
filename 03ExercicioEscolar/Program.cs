using System;

namespace _03ExercicioEscolar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Lucas";
            a.nota1 = 6;
            a.nota2 = 3;
            a.mensagem();

        }
    }
}