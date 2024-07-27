using System;
using System.Net.Http.Headers;
using System.Xml;

// using == import em JAVA
// namespaces == package em JAVA

namespace MeuApp
{

    class Program
    {
        static void Main(string[] args)
        {
            
            
            var teclado = new Produto(12,"Roland fhanton",20300.55,ETipoDeProduto.Produto);
            var tocando = new Produto(2, "tocando um culto", 200, ETipoDeProduto.Servico);
            Console.WriteLine(teclado.Id);
            Console.WriteLine(teclado.Nome);
            Console.WriteLine(teclado.Preco);
            Console.WriteLine(teclado.Tipo);
            teclado.Id = 1;
            teclado.Preco = 22500.50;
            teclado.Nome = "Nord Stage 3";
            teclado.Tipo = ETipoDeProduto.Produto;
            Console.WriteLine(teclado.Id);
            Console.WriteLine(teclado.Nome);
            Console.WriteLine(teclado.Preco);
            Console.WriteLine(teclado.Tipo);
            Console.WriteLine(tocando.Id);
            Console.WriteLine(tocando.Nome);
            Console.WriteLine(tocando.Preco);
            Console.WriteLine(tocando.Tipo);

            
            var arr = new string[2];
            arr[0] = "Item 1";

            var arr2 = arr;


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Rodou "+i+1+" vezes!");
            }

            string valor = "joão";
            switch (valor)
            {
                case "joão":
                    Console.WriteLine("É o cara!!");
                    break;
                case "marcelo":
                    Console.WriteLine("Não é o cara!!!");
                    break;

            }

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
    
    struct Produto
    {
        public Produto(int id, string nome, double preco, ETipoDeProduto tipo)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Tipo = tipo;
        }
        
        public int Id;
        public double Preco;
        public string Nome;
        public ETipoDeProduto Tipo;

        public double PriceInDolar(double dolar)
        {
            return Preco * dolar;
        }
    }

    enum ETipoDeProduto
    {
        Produto = 1,
        Servico = 2
    }
}