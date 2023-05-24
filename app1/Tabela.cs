using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa2_prog2
{
    public class Planeta {
            public int num { get; set; }
            public double g { get; set; }
            public string nome { get; set; }
        public Planeta(int num, double g, string nome)
        {
            this.num = num;
            this.g = g;
            this.nome = nome;
        }
    }
    internal class Tabela
    {
        protected Planeta[] planetas;
        public Tabela(Planeta[] planetas)
        {
            this.planetas = planetas;
        }

        public void Print()
        {
            Console.WriteLine(" # | Gravidade relativa | Planeta ");
            foreach(Planeta planet in planetas)
            Console.WriteLine($" {planet.num} | {planet.g}               | {planet.nome}");
        }

        public bool PrintPeso(int id, double peso)
        {
            if(id == 0)
            {
                foreach (Planeta planet in planetas)
                {
                    string nomeEditado = planet.nome.PadRight(10, ' ');
                    Console.WriteLine($" Peso em: {nomeEditado}: {(peso / 10) * planet.g:F2} KG ");
                }
                return true;
            }
            else foreach (Planeta planet in planetas)
                if (planet.num == id) { Console.WriteLine($" Peso em {planet.nome}: {(peso / 10) * planet.g} KG "); return  true; }
            return false;
        }
    }
}
