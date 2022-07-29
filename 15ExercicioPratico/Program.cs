using System;

namespace _15ExercicioPratico
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();

            Console.WriteLine("Deseja sair do app? 0 para sim e 1 para não");
            int x = Convert.ToInt32(Console.ReadLine());
            while (x != 0)
            {
                Console.WriteLine("Digite seus dados por favor");
                
                Console.WriteLine("Você é terceirizado? sim ou nao");
                string terceirizado = Convert.ToString(Console.ReadLine());
                terceirizado = terceirizado.ToLower();
                
                Console.WriteLine("Qual o seu nome?");
                string nome = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("Quantas horas você trabalhou?");
                int horas = Convert.ToInt32(Console.ReadLine());
               
                Console.WriteLine("Qual o valor da sua hora?");
                double valorHora = Convert.ToDouble(Console.ReadLine());
                double adicional;
                if (terceirizado == "sim")
                {
                    Console.WriteLine("Qual o seu adicional?");
                    adicional = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("-----------------------");
                    Funcionario f = new Funcionario(terceirizado, nome, horas, valorHora, adicional);
                    listaFuncionarios.Add(f);
                }
                else if (terceirizado == "nao")
                {
                    Console.WriteLine("-----------------------");
                    Funcionario f = new Funcionario(terceirizado, nome, horas, valorHora);
                    listaFuncionarios.Add(f);
                }
                else 
                {
                    throw new ArgumentException("valor invalido");
                }
                
                Console.WriteLine("Deseja sair do app? 0 para sim e 1 para não");
                x = Convert.ToInt32(Console.ReadLine());


            }
            
            foreach (Funcionario aux in listaFuncionarios)
            {
                Console.WriteLine("Terceirizado: "+aux.terceirizado);
                Console.WriteLine("Nome: "+aux.nome);
                Console.WriteLine("Horas: "+aux.horas);
                Console.WriteLine("Valor da hora: "+aux.valorHora);
                Console.WriteLine("Adicional: "+aux.adicional);
                Console.WriteLine("-----------------------");
            }
            foreach (Funcionario aux in listaFuncionarios)
            {
                Console.WriteLine(aux.nome + " - " + aux.salario + " R$");
            }

        }
    }
}