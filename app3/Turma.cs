namespace Turma
{
    public class Aluno
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }

    public class Turma
    {
        private const int LIM = 3;
        private static Aluno[] alunos = new Aluno[LIM];

        public static void Main(string[] args)
        {
            // Cadastrar os alunos na turma
            for (int i = 0; i < LIM; i++)
            {
                Aluno aluno = new Aluno();

                Console.Write("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Digite a idade do aluno: ");
                aluno.Idade = Convert.ToInt32(Console.ReadLine());

                alunos[i] = aluno;
            }

            // Imprimir os alunos cadastrados
            Console.WriteLine("\nAlunos cadastrados:");

            foreach (Aluno aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}, Idade: {aluno.Idade} anos");
            }
        }
    }
}
