namespace ExerciciosDeFundamentos.WumpusGame;

public class WumpusGame
{
    public static void Main(string[] args)
    {
        var dimensaoTabuleiro = GetDimensaoTabuleiro();
        DesenharTabuleiro(dimensaoTabuleiro);
    }

    static int GetDimensaoTabuleiro()
    {
        Console.Clear();
        Console.WriteLine("Informe a dimensão do tabuleiro OBS: Minimo 5");
        int dimensaoTabuleiro = int.Parse(Console.ReadLine());
        while (dimensaoTabuleiro < 5)
        {
            Console.WriteLine("Valor inválido. Por favor informe uma dimensao de no minimo 5");
            dimensaoTabuleiro = int.Parse(Console.ReadLine());
        }

        return dimensaoTabuleiro;
    }

    static void DesenharTabuleiro(int dimensaoTabuleiro)
    {
        int Pontuacao = 1000;
        string[,] tabuleiro = new string[dimensaoTabuleiro, dimensaoTabuleiro];
        int iPersonagem = NumeroAleatorio(dimensaoTabuleiro);
        int jPersonagem = NumeroAleatorio(dimensaoTabuleiro);
        int iGold = NumeroAleatorio(dimensaoTabuleiro);
        int jGold = NumeroAleatorio(dimensaoTabuleiro);
        int iMonstro = NumeroAleatorio(dimensaoTabuleiro);
        int jMonstro = NumeroAleatorio(dimensaoTabuleiro);

        Console.Write("#");
        for (int j = 0; j < dimensaoTabuleiro; j++)
        {
            Console.Write("#");
        }

        Console.Write("#");
        Console.Write("\n");

        for (int i = 0; i < dimensaoTabuleiro; i++)
        {
            Console.Write("#");
            for (int j = 0; j < dimensaoTabuleiro; j++)
            {
                tabuleiro[i, j] = " ";
                tabuleiro[iPersonagem, jPersonagem] = "P";
                tabuleiro[iGold, jGold] = "G";
                tabuleiro[iMonstro, jMonstro] = "W";

                Console.Write(tabuleiro[i, j]);
            }

            Console.Write("#");
            Console.Write("\n");
        }

        Console.Write("#");
        for (int j = 0; j < dimensaoTabuleiro; j++)
        {
            Console.Write("#");
        }

        Console.Write("#");
        Console.Write("\n");

        UpdateTabuleiro();

        void UpdateTabuleiro()
        {
            Console.WriteLine("1 - Andar para esquerda");
            Console.WriteLine("2 - Andar para cima");
            Console.WriteLine("3 - Andar para direita");
            Console.WriteLine("4 - Andar para baixo");
            Console.WriteLine("Faça um movimento: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                for (int i = 0; i < dimensaoTabuleiro; i++)
                {
                    for (int j = 0; j < dimensaoTabuleiro; j++)
                    {
                        if (tabuleiro[i, j] == "P")
                        {
                            var iPersonagem = i;
                            var jPersonagem = j;
                            //verificar se o movimento é valido
                            if (j - 1 < 0)
                            {
                                Console.WriteLine("Movimento invalido! Por favor repita o movimento.");
                                UpdateTabuleiro();
                            }
                            else
                            {
                                Pontuacao -= 1;
                                tabuleiro[i, j] = " ";
                                tabuleiro[iMonstro, jMonstro] = " ";
                                tabuleiro[iMonstro = MovimentoMonstroY(iPersonagem),
                                    jMonstro = MovimentoMonstroX(jPersonagem)] = "W";
                                //Verificar se existe o Gold
                                if (tabuleiro[i, j - 1] == "G")
                                {
                                    tabuleiro[i, j - 1] = "P";
                                    LerTabuleiro();
                                    Console.WriteLine("Parabens vc conseguiu resgatar o tesouro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }
                                //verificar se existe o monstro
                                else if (tabuleiro[i, j - 1] == "W")
                                {
                                    tabuleiro[i, j - 1] = "W";
                                    LerTabuleiro();
                                    Console.WriteLine("Você foi capturado pelo monstro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }

                                tabuleiro[i, j - 1] = "P";
                                LerTabuleiro();
                                UpdateTabuleiro();
                            }
                        }
                    }
                }
            }
            else if (opcao == 2)
            {
                for (int i = 0; i < dimensaoTabuleiro; i++)
                {
                    for (int j = 0; j < dimensaoTabuleiro; j++)
                    {
                        if (tabuleiro[i, j] == "P")
                        {
                            var iPersonagem = i;
                            var jPersonagem = j;
                            //verificar se o movimento é valido
                            if (i - 1 < 0)
                            {
                                Console.WriteLine("Movimento invalido! Por favor repita o movimento.");
                                UpdateTabuleiro();
                            }
                            else
                            {
                                Pontuacao -= 1;
                                tabuleiro[i, j] = " ";
                                tabuleiro[iMonstro, jMonstro] = " ";
                                tabuleiro[iMonstro = MovimentoMonstroY(iPersonagem),
                                    jMonstro = MovimentoMonstroX(jPersonagem)] = "W";
                                //Verificar se existe o Gold
                                if (tabuleiro[i - 1, j] == "G")
                                {
                                    tabuleiro[i - 1, j] = "P";
                                    LerTabuleiro();
                                    Console.WriteLine("Parabens vc conseguiu resgatar o tesouro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }
                                //verificar se existe o monstro
                                else if (tabuleiro[i - 1, j] == "W")
                                {
                                    tabuleiro[i - 1, j] = "W";
                                    LerTabuleiro();
                                    Console.WriteLine("Você foi capturado pelo monstro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }

                                tabuleiro[i - 1, j] = "P";
                                LerTabuleiro();
                                UpdateTabuleiro();
                            }
                        }
                    }
                }
            }
            else if (opcao == 3)
            {
                for (int i = 0; i < dimensaoTabuleiro; i++)
                {
                    for (int j = 0; j < dimensaoTabuleiro; j++)
                    {
                        if (tabuleiro[i, j] == "P")
                        {
                            var iPersonagem = i;
                            var jPersonagem = j;
                            //verificar se o movimento é valido
                            if (j + 1 >= dimensaoTabuleiro)
                            {
                                Console.WriteLine("Movimento invalido! Por favor repita o movimento.");
                                UpdateTabuleiro();
                            }
                            else
                            {
                                Pontuacao -= 1;
                                tabuleiro[i, j] = " ";
                                tabuleiro[iMonstro, jMonstro] = " ";
                                tabuleiro[iMonstro = MovimentoMonstroY(iPersonagem),
                                    jMonstro = MovimentoMonstroX(jPersonagem)] = "W";
                                //Verificar se existe o Gold
                                if (tabuleiro[i, j + 1] == "G")
                                {
                                    tabuleiro[i, j + 1] = "P";
                                    LerTabuleiro();
                                    Console.WriteLine("Parabens vc conseguiu resgatar o tesouro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }
                                //verificar se existe o monstro
                                else if (tabuleiro[i, j + 1] == "W")
                                {
                                    tabuleiro[i, j + 1] = "W";
                                    LerTabuleiro();
                                    Console.WriteLine("Você foi capturado pelo monstro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }

                                tabuleiro[i, j + 1] = "P";
                                LerTabuleiro();
                                UpdateTabuleiro();
                            }
                        }
                    }
                }
            }
            else if (opcao == 4)
            {
                for (int i = 0; i < dimensaoTabuleiro; i++)
                {
                    for (int j = 0; j < dimensaoTabuleiro; j++)
                    {
                        if (tabuleiro[i, j] == "P")
                        {
                            var iPersonagem = i;
                            var jPersonagem = j;
                            //verificar se o movimento é valido
                            if (i + 1 >= dimensaoTabuleiro)
                            {
                                Console.WriteLine("Movimento invalido! Por favor repita o movimento.");
                                UpdateTabuleiro();
                            }
                            else
                            {
                                Pontuacao -= 1;
                                tabuleiro[i, j] = " ";
                                tabuleiro[iMonstro, jMonstro] = " ";
                                tabuleiro[iMonstro = MovimentoMonstroY(iPersonagem),
                                    jMonstro = MovimentoMonstroX(jPersonagem)] = "W";
                                //Verificar se existe o Gold
                                if (tabuleiro[i + 1, j] == "G")
                                {
                                    tabuleiro[i + 1, j] = "P";
                                    LerTabuleiro();
                                    Console.WriteLine("Parabens vc conseguiu resgatar o tesouro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }
                                //verificar se existe o monstro
                                else if (tabuleiro[i + 1, j] == "W")
                                {
                                    tabuleiro[i + 1, j] = "W";
                                    LerTabuleiro();
                                    Console.WriteLine("Você foi capturado pelo monstro");
                                    Console.WriteLine($"Pontuação: {Pontuacao}");
                                    System.Environment.Exit(0);
                                }

                                tabuleiro[i + 1, j] = "P";
                                LerTabuleiro();
                                UpdateTabuleiro();
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Por favor escolha as opçoes de 1 a 4");
                UpdateTabuleiro();
            }
        }

        void LerTabuleiro()
        {
            Console.Write("#");
            for (int j = 0; j < dimensaoTabuleiro; j++)
            {
                Console.Write("#");
            }

            Console.Write("#");
            Console.Write("\n");

            for (int i = 0; i < dimensaoTabuleiro; i++)
            {
                Console.Write("#");
                for (int j = 0; j < dimensaoTabuleiro; j++)
                {
                    Console.Write(tabuleiro[i, j]);
                }

                Console.Write("#");
                Console.Write("\n");
            }

            Console.Write("#");
            for (int j = 0; j < dimensaoTabuleiro; j++)
            {
                Console.Write("#");
            }

            Console.Write("#");
            Console.Write("\n");
        }

        int MovimentoMonstroX(int jPersonagem)
        {
            Random numAleatorio = new Random();
            var movimentoAleatorio = numAleatorio.Next(2);
            if (movimentoAleatorio == 0)
            {
                if (jPersonagem > jMonstro)
                {
                    jMonstro += 1;
                    return jMonstro;
                }
                if (jPersonagem < jMonstro)
                {
                    jMonstro -= 1;
                    return jMonstro;
                }
            }
            else if (movimentoAleatorio == 1)
            {
                if (jPersonagem > jMonstro)
                {
                    return jMonstro;
                }

                if (jPersonagem < jMonstro)
                {
                    return jMonstro;
                }
            }

            return jMonstro;
        }

        int MovimentoMonstroY(int iPersonagem)
        {
            Random numAleatorio = new Random();
            var movimentoAleatorio = numAleatorio.Next(2);
            if (movimentoAleatorio == 0)
            {
                if (iPersonagem > iMonstro)
                {
                    iMonstro += 1;
                    return iMonstro;
                }

                if (iPersonagem < iMonstro)
                {
                    iMonstro -= 1;
                    return iMonstro;
                }
            }
            else if (movimentoAleatorio == 1)
            {
                if (iPersonagem > iMonstro)
                {
                    return iMonstro;
                }

                if (iPersonagem < iMonstro)
                {
                    return iMonstro;
                }
            }

            return iMonstro;
        }
    }

    static int NumeroAleatorio(int dimensaoTabuleiro)
    {
        Random numeroAleatorio = new Random();
        return numeroAleatorio.Next(dimensaoTabuleiro);
    }
}