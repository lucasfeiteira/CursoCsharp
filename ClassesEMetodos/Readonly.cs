﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento;

        public Cliente (string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;

            Nascimento = new DateTime(2020, 10, 10);
        }

        public string GetDataDeNascimente () { 
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    
    
    
    
    
    internal class Readonly {

        public static void Executar() {
            var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 22));

            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimente());
        
        
        }
    }
}
