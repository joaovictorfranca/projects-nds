using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = new StringBuilder();
            txt.Append("Este texto é um teste");
            txt.Append(" é um teste");
            txt.Append(" Este texto");
            txt.Append(" Este um teste");

            txt.ToString();
            Console.WriteLine(txt);

/*
            Console.WriteLine(txt.Trim()); // Trim serve para limpar espaços do inicio e do fim das strings! caso o usuario dẽ um espaço no final ou no começo e for comparar com outra string!


            var divisao = txt.Split(" ");      // o Split está dividindo a string pelo caractere escolhido que no caso é por um espaço " "
            Console.WriteLine(divisao[0]);
            Console.WriteLine(divisao[1]);
            Console.WriteLine(divisao[2]);
            Console.WriteLine(divisao[3]);
            Console.WriteLine(divisao[4]);


            Console.WriteLine(txt.Replace("Este", "Isto"));       // O Replace irá substituir um valor por outro expecificado
            Console.WriteLine(txt.Replace("e", "X"));             // primero

            Console.WriteLine(txt.Length);  // tamanho da string

            Console.WriteLine(txt.Insert(11, "aqui "));
            Console.WriteLine(txt.Remove(11, 1));

            Console.WriteLine(txt.ToLower());  // converte tudo para minusculo
            Console.WriteLine(txt.ToUpper());  // converte tudo para maiusculo

            Console.WriteLine(txt.IndexOf("é")); // sempre tem que colocar dentro do metodo indexOf um valor de mesmo tipo, se for uma string.indexOf(aqui dentro tem que ter uma string), se for um inteiro dentro tem que ter um inteiro.
                                                 // retorna o numero da posição!
            Console.WriteLine(txt.LastIndexOf("s")); // Vai retornar a posição do ultimo elemento, por exemplo a posição do ultimo s naquela string!, pode ser outros tipos tbm.. inteiro double, dentre outros!

            Console.WriteLine(txt.Equals("Este texto é um teste"));
            Console.WriteLine(txt.Equals("este texto é um teste"));
            Console.WriteLine(txt.Equals("Este texto é um teste",StringComparison.OrdinalIgnoreCase));

            Console.WriteLine(txt.StartsWith("Este"));
            Console.WriteLine(txt.StartsWith("este"));
            Console.WriteLine(txt.StartsWith("texto"));

            Console.WriteLine(txt.EndsWith("teste"));
            Console.WriteLine(txt.EndsWith("Teste"));
            Console.WriteLine(txt.EndsWith("xpro"));

            Console.WriteLine(txt.Contains("teste")); //ele retorna um booleano, ele é case sensitive
            Console.WriteLine(txt.Contains("Teste", StringComparison.OrdinalIgnoreCase));  //Assim ele ignora o case sensitive!

            var texto = "Testando";

            Console.WriteLine(texto.CompareTo("Testando"));   //ele retorna um inteiro 0 para quando ele é completamente igual.
                                                                  //Se o objeto atual for menor que o objeto passado como argumento, o método deve retornar um número negativo.
                                                                  //Se o objeto atual for maior que o objeto passado como argumento, o método deve retornar um número positivo.


            var price = 10.2;
            var texto = string.Format("O preço do produto é {0} apenas na promoção {1}", price, true);
            var txt = $"O preço do produto é {price} apenas na promoção";   //podemos colocar um @ antes das strings ex: @"!@#$%&*()'';:"  isso significa que essa string pode conter caracteres especiais, podendo usar o /n e ele não irá quebrar a linha inclusive!

            Console.WriteLine(texto + txt);

            var id = Guid.NewGuid(); //Guid gera um numero bem grande aleatório que pode ser usado em ID pois como é bem grande é pouco provável que se repita!

            id.ToString(); //transforma para string

            id = new Guid("dc639d92-cc8f-4ae5-b697-8d63fccfb30e");  //para setar um Guid tem que estar no formato correto! poré ele consegue gerar o restante do guid se vc setar apenas o inicio!

            Console.WriteLine(id.ToString().Substring(0,8)); //Printando apenas os primeiros 8 caracteres do Guid!

            if (id == Guid.NewGuid())
            {
                Console.WriteLine("São iguais");
            }
            */
        }
    }
}

