using System;

abstract class PontoColorido
{
    public abstract string GetCor();

    public virtual string RetornaPonto()
    {
        return string.Empty;
    }

    public string ImprimePonto()
    {
        return "<" + GetCor() + ">" + "<" + RetornaPonto() + ">" + "<" + GetCor() + ">";
    }
}

class Ponto
{
    private int x;
    private int y;

    public void SetX(int x)
    {
        this.x = x;
    }

    public void SetY(int y)
    {
        this.y = y;
    }

    public string RetornaPonto()
    {
        return x + ", " + y;
    }
}

class PontoAzul : PontoColorido
{
    public override string GetCor()
    {
        return "Azul";
    }
}

class PontoVerde : PontoColorido
{
    public override string GetCor()
    {
        return "Verde";
    }
}

class TestaPonto
{
    static void Main(string[] args)
    {
        PontoAzul pontoAzul = new PontoAzul();
        Ponto ponto1 = new Ponto();
        ponto1.SetX(5);
        ponto1.SetY(3);

        PontoVerde pontoVerde = new PontoVerde();
        Ponto ponto2 = new Ponto();
        ponto2.SetX(2);
        ponto2.SetY(7);

        Console.WriteLine("Um ponto Azul: " + pontoAzul.ImprimePonto());
        Console.WriteLine("Um ponto Verde: " + pontoVerde.ImprimePonto());
        Console.WriteLine("Um ponto Azul: " + pontoAzul.ImprimePonto());
        Console.WriteLine("Um ponto Azul: " + pontoAzul.ImprimePonto());
        Console.WriteLine("Um ponto Verde: " + pontoVerde.ImprimePonto());
        Console.WriteLine("Um ponto Azul: " + pontoAzul.ImprimePonto());
        Console.WriteLine("Um ponto Verde: " + pontoVerde.ImprimePonto());
    }
}
