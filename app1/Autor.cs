using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa2_prog2
{
    public static class Autor
    {
        public static void SolicitarExibicao()
        {
            Console.WriteLine(" Deseja ver as informações de quem criou o programa? [S/N]");
            var resposta = Console.ReadLine();
            if (resposta != null && resposta == "S" || resposta == "s")
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("     Yshrael Pimentel - 202211140034          ");
                Console.WriteLine("       Sistemas de Informação-UFPA            ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("\n\n");
            }
            else Console.Clear();
        }
    }
}
