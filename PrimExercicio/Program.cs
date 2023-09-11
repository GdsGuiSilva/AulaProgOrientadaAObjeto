using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimExercicio
{
    public class Program
    {
        ContaBancaria conta1;
        public Program()
        {
            conta1 = new ContaBancaria();
            conta1.Saldo = 0;
            conta1.Nrconta = "00800";
            conta1.Nometitular = "Lucas";
            conta1.DepositoDin(400);
            if(conta1.Saldo <= 0)
            {
                Console.WriteLine("Não há como fazer saque com saldo menor do que zero");
            }
            else
            {
                conta1.SaqueDin(500);
            }
            Console.WriteLine(conta1.ToString());
        }
    static void Main(string[] args)
        {
            Program test = new Program();
            Console.ReadLine();
        }
    }
}
