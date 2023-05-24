using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2
{
    public class NumeroComplexo
    {
        private double parteReal;
        private double parteImaginaria;

        public void InicializaNumero(double real, double imaginaria)
        {
            this.parteReal = real;
            this.parteImaginaria = imaginaria;
        }

        public void ImprimeNumero()
        {
            Console.WriteLine($"{this.parteReal} + {this.parteImaginaria}i");
        }

        public bool EIgual(NumeroComplexo outroNumero)
        {
            return this.parteReal == outroNumero.parteReal && this.parteImaginaria == outroNumero.parteImaginaria;
        }

        public void Soma(NumeroComplexo outroNumero)
        {
            this.parteReal += outroNumero.parteReal;
            this.parteImaginaria += outroNumero.parteImaginaria;
        }

        public void Subtrai(NumeroComplexo outroNumero)
        {
            this.parteReal -= outroNumero.parteReal;
            this.parteImaginaria -= outroNumero.parteImaginaria;
        }

        public void Multiplica(NumeroComplexo outroNumero)
        {
            double novoReal = this.parteReal * outroNumero.parteReal - this.parteImaginaria * outroNumero.parteImaginaria;
            double novoImaginario = this.parteReal * outroNumero.parteImaginaria + this.parteImaginaria * outroNumero.parteReal;
            this.parteReal = novoReal;
            this.parteImaginaria = novoImaginario;
        }

        public void Divide(NumeroComplexo outroNumero)
        {
            double denominador = Math.Pow(outroNumero.parteReal, 2) + Math.Pow(outroNumero.parteImaginaria, 2);
            double novoReal = (this.parteReal * outroNumero.parteReal + this.parteImaginaria * outroNumero.parteImaginaria) / denominador;
            double novoImaginario = (this.parteImaginaria * outroNumero.parteReal - this.parteReal * outroNumero.parteImaginaria) / denominador;
            this.parteReal = novoReal;
            this.parteImaginaria = novoImaginario;
        }
    }

}
