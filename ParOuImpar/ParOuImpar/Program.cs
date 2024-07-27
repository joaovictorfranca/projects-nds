bool loop = true;
while (loop != false)
{
    Console.WriteLine("Digite um número inteiro para saber se é par ou impar: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());

    float resto = numeroDigitado % 2;

    if (resto == 0)
    {
        Console.WriteLine("Seu numero é par!!!");
    }
    else
    {
        Console.WriteLine("Seu numero é impar!!!");
    }

        Console.WriteLine("deseja realizar outra consulta? 1 para sim e 0 para não: ");
    string saiOuN = Console.ReadLine();
    while (saiOuN != "0" & saiOuN != "1")
    {
        Console.WriteLine("Coloque 1 para Sim ou 0 para não: ");
        saiOuN = Console.ReadLine();
    }

    if (saiOuN == "0")
    {
        loop = false;
    }
    else
        loop = true;

}
