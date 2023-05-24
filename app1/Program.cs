using tarefa2_prog2;
Planeta p1 = new Planeta(1, 0.37, "Mercúrio");
Planeta p2 = new Planeta(2, 0.88, "Vênus");
Planeta p3 = new Planeta(3, 0.38, "Marte");
Planeta p4 = new Planeta(4, 2.64, "Júpiter");
Planeta p5 = new Planeta(5, 1.15, "Saturno");
Planeta p6 = new Planeta(6, 1.17, "Urano");
Planeta[] listDePlanetas = { p1, p2, p3, p4, p5, p6 };
Tabela tb = new Tabela(listDePlanetas);

Console.Clear();
Autor.SolicitarExibicao();

bool test = true;
bool TestNovaEscolha = false;
double pesoTerra = 0;
string msg1 = "";
while (test)
{
    if(!TestNovaEscolha)
    {
        Console.WriteLine($" Olá, terráquio! Seu peso seria{msg1}: ");
        var respostaPeso = Console.ReadLine();
        if (respostaPeso != null)
            if (double.TryParse(respostaPeso, out pesoTerra) && pesoTerra > 20)
            {
                // A conversão foi bem-sucedida
                Console.WriteLine($" Peso em Terra: {pesoTerra}KG");

                if (pesoTerra > 50) Console.WriteLine(" Você sabia que a terra pesa aproximadamente 5,972×10^24kg? Se vc sair dela ela perderia 33,32% de sua massa!");
                Console.WriteLine("\n\n Essa é a tabela com alguns planetas e suas respectivas gravidades. Escolha o número referente ao planeta que você quer saber seu peso. (zero[0] para todos)\n");
                tb.Print();
                var PlanetaEscolhido = Console.ReadLine();
                if (PlanetaEscolhido != null)
                {
                    bool achouPlaneta = tb.PrintPeso(Int32.Parse(PlanetaEscolhido), pesoTerra);
                    if (achouPlaneta)
                    {
                        Console.WriteLine(" Quer escolher um outro planeta? [S/N]");
                        var novaEscolha = Console.ReadLine();
                        if (novaEscolha == null || novaEscolha != "S" && novaEscolha != "s") break;
                        Console.Clear();
                        TestNovaEscolha = true;
                        continue;
                    }
                }
                Console.WriteLine(" Número inválido!");
            }
            else
            {
                Console.WriteLine(" Pare de mentir seu peso! Esse peso é inválido...");
                Console.WriteLine(" Vamos tentar de novo? [S/N]");
            }
        var respostaContinuar = Console.ReadLine();
        if (respostaContinuar == null || respostaContinuar != "S" && respostaContinuar != "s") test = false;
        msg1 = "(Sem mentir)";
        Console.Clear();
    }

    else
    {
        tb.Print();
        var PlanetaEscolhido = Console.ReadLine();
        if (PlanetaEscolhido != null)
        {
            if(pesoTerra != 0)
            {
                try {
                    bool achouPlaneta = tb.PrintPeso(Int32.Parse(PlanetaEscolhido), pesoTerra);
                    if (achouPlaneta)
                    {
                        Console.WriteLine(" Quer escolher um outro planeta? [S/N]");
                        var novaEscolha = Console.ReadLine();
                        if (novaEscolha == null || novaEscolha != "S" && novaEscolha != "s") break;
                        Console.Clear();
                        continue;
                    }
                } catch { }
            }
           
        }
        Console.WriteLine(" Número inválido!");
    }
}
Console.WriteLine("\n\n ---- FIM APLICAÇÃO ----- \n\n");