using System;
using Jogo_RPG_C# ;

namespace Jogo_RPG_C# {
    class Program{
        static void Main(string[] args){

             Hero arus = new Hero("Arus", 23, "Knight");
             Wizard wizard = new Wizard("Flans", 99, "devil");

             Console.WriteLine(wizard.Attack);
             Console.WriteLine(wizard.Attack);
        }
    }
}