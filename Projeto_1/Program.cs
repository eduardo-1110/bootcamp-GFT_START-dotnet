using System;
using Projeto_1.src;

namespace Projeto_1{

    class Program{

        static void Main(string[] args){

            Knigth arus = new Knigth("Arus", 29 , "Knigth");
            Wizard wizard = new Wizard("Jennica", 34 , "White Wizard");
            Ninja ninja = new Ninja("Wedze", 15 , "Ninja");
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(11));
            Console.WriteLine(ninja.Attack());

        }




    }


    //Console.WriteLine("Hello, World!");
}

