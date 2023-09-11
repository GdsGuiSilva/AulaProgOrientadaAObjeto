using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegExercicio
{
    public class Program
    {
        Funcionario func1;
        public Program()
        {
            func1 = new Funcionario();
            func1.Nome = "Fernando";
            func1.Salario = 3200;
            func1.Cargo = "Administrador de Redes";
            func1.ReajustaSalario(0.25);
            Console.WriteLine(func1.ToString());
        }
        static void Main(string[] args)
        {
            Program func = new Program();
            Console.ReadLine();
        }
    }
}
