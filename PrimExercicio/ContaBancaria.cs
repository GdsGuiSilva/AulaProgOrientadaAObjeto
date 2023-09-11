using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace PrimExercicio
{
    public class ContaBancaria
    {
        private string nrconta;
        private float saldo;
        private string nometitular;

        public string Nrconta
        {
            get
            {
                return nrconta;
            }
            set
            {
                nrconta = value;
            }
        }
        public float Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                saldo = value;
            }

        }
        public string Nometitular
        {
            get
            {
                return nometitular;
            }
            set
            {
                nometitular = value;
            }
        }
        public override string ToString()
        {
            string all;
            all = "["+nrconta+","+saldo+","+nometitular+"]";
            return all;
        }

        public float SaqueDin(float saque)
        {
            saldo = saldo - saque;
            return saldo;
        }

        public float DepositoDin(float deposito)
        {
            saldo = saldo + deposito;
            return saldo;
        }
    }
}