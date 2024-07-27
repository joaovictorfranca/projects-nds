using System;

// using == import em JAVA
// namespaces == package em JAVA

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            int numero = 25;
            string numerostr = numero.ToString();
            //a classe Convert permite converter varios tipos para um inteiro por exemplo... não só uma string... pode ser um double, float, boll, dentre outros
            //ele popde dar um erro em tempo de execução que é após a compilação... qnd pode esta sendo executado até mesmo na máquina do cliente!
            int inteiro1 = Convert.ToInt32("100");
            
            //A extenção dos tipos .parse é mais ultilizada para converter uma string para o tipo especificado
            int inteiro = int.Parse("100");
            
            //Para que uma variável assuma o valor nulo tem que ter um ponto de interrogação após a declaração da variavel (null == vazio)
            int? variavelNula = null;
            
            bool tocou = true;

            const int PIN_PIN = 2324;

            float real = 25.5f;

            int idade = 24;

            uint inteiroSemSinal = (uint)idade;  //convertendo inteiro idade em inteiro sem sinal
            
            var nome = "João";

            Console.WriteLine("Nome: "+nome+"\n inteiro sem sinal: "+inteiroSemSinal+" \nIdade: "+idade+" \nPin: "+PIN_PIN+ "\nVariavel nula: "+variavelNula+"\nTocou? "+tocou+ "\nFloat real: "+real+"\nnumero: "+numero+"\nnumero em string: "+numerostr);
        }
    }
}