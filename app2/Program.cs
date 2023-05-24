using app2;

/*
 * Yshrael Pimentel - 202211140034
 * Sistemas de Informação
 */

class Program
{
    static void Main(string[] args)
    {
        NumeroComplexo numero1 = new NumeroComplexo();
        numero1.InicializaNumero(2.0, 3.0);
        numero1.ImprimeNumero(); // Saída: 2 + 3i

        NumeroComplexo numero2 = new NumeroComplexo();
        numero2.InicializaNumero(1.5, 2.5);

        bool igual = numero1.EIgual(numero2);
        Console.WriteLine(igual); // Saída: False

        numero1.Soma(numero2);
        numero1.ImprimeNumero(); // Saída: 3.5 + 5.5i

        numero1.Subtrai(numero2);
        numero1.ImprimeNumero(); // Saída: 2 + 3i

        numero1.Multiplica(numero2);
        numero1.ImprimeNumero(); // Saída: -5 + 10i

        numero1.Divide(numero2);
        numero1.ImprimeNumero(); // Saída: 2
    }
}

