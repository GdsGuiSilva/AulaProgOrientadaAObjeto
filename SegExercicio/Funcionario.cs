using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegExercicio
{
    public class Funcionario
    {
        private string nome;
        private double salario;
        private string cargo;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }
        public double Salario
        {
            get
            {
                return salario;
            }
            set
            {
                salario = value;
            }
        }

        public string Cargo
        {
            get
            {
                return cargo;
            }
            set
            {
                cargo = value;
            }
        }

        public double ReajustaSalario(double percent)
        {
            salario = salario +(salario * percent);
            return salario;
        }

        public override string ToString()
        {
            string cadeia;
            cadeia = "["+nome+","+salario+","+cargo+"]";
            return cadeia;
        }
    }
}