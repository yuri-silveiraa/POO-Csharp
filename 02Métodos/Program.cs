﻿using System;

namespace _02Métodos // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Instanciar um objeto
            Pessoa obj = new Pessoa();
            obj.apresentar();
            obj.apresentar("Yuri", 21);

        }
    }
}
