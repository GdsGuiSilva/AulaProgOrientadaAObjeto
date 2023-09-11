using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TerceiroExercicio
{
    public class Carro
    {
        private string marca;
        private string modelo;
        private string ano;
        private int quilometragem;
        public string Marca
        {
            get
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }
        public string Modelo
        {
            get
            {
                return modelo;
            }
            set
            {
                modelo = value;
            }
        }
        public string Ano
        {
            get
            {
                return ano;
            }
            set
            {
                ano = value;
            }
        }
        public int Quilometragem
        {
            get
            {
                return quilometragem;
            }
            set
            {
                quilometragem = value;
            }
        }
        public string Revisao()
        {
            return "REVISAO";
        }
    }
}