namespace Payments;

class Program
{
    static void Main(string[] args)
    {
        
    }
}

public class Pessoa
{
    public string Nome { get; set; }
}

public class PessoaFisica : Pessoa
{
    public string CPF { get; set; }
}

public class PessoaJuridica : Pessoa
{
    public string CNPJ { get; set; }
}
/*

public interface IPagamento
{
    DateTime Vencimento { get; set; }

    void Pagar(double valor);
}                                                                                                                                Carro carro = new Carro(60)

public abstract class Pagamento : IPagamento
{
    public DateTime Vencimento { get; set; }
    public virtual void Pagar(double valor)
    {
        //executa algooo!!!
        throw new NotImplementedException();
    }
}

public class PagamentoCartaoCredito : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public class PagamentoBoleto : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}

public class PagamentoApplePay : Pagamento
{
    public override void Pagar(double valor)
    {
        base.Pagar(valor);
    }
}


/*
public static class Settings
{
    public static string API_URL { get; set; }

}

public class Pagamento : IDisposable
{
    public Pagamento()
    {
        Console.WriteLine("Iniciando o pagamento");
    }

    public void Dispose()
    {
        Console.WriteLine("Finalizando o pagamento");
    }
}

// private ela vai ser visivel apenas na classe dela... protected ela ficará visivel apenas para ela e as classes filhos dela...
// internal fica disponivel sendo do mesmo namespace, dentro do mesmo assembler... public vica visivel a todos
class Pagamento
{
    //atributos ou propriedades  (variáveis com diferenças)
    public DateTime Vencimento {
        get;
        set;
    }

    private DateTime _dataPagamento;
    public DateTime DataPagamento
    {
        get
        {
            Console.WriteLine("Lendo o valor");
            return _dataPagamento;
        }
        set
        {
            Console.WriteLine("Atribuindo o valor");
            _dataPagamento = value;
        }
    }

    //Métodos (funções criadas) //métodos privados ficam escondidos das demais classes, numa instancia não ficará visivel
    public virtual void Pagar()           // O virtual permite que o método seja sobrescrito pela classe filho... na classe filho tem que ter a anotação override (isso de chama sobrescrita de método)
    {

    }

    public Pagamento()
    {
        Console.WriteLine("iniciando pagamento!"); // método construtor... quando uma classe tem esse método sempre que ela for instanciada cai ser executado esse método!
        DataPagamento=DateTime.Now;
    }

    public void Consultar(string a){}                                 //  Isso se
                                                                      //          chama
    public void Consultar(string a, int b){}                          //                sobrecarga
                                                                      //                           de
    public void Consultar(string a, int b, DateTime vencimento){}     //                              método


    public override string ToString()      // como eu dei o override no método ToString herdado da classe mãe System...
                                           // agora sempre que for chamado esse método nessa classe pagamento ele n irá retornar a concatenação do namespace com a classe e sim oq eu formatei dentro do método
    {
        return Vencimento.ToString("dd/mm/yyyy");
    }
}

class PagamentoBoleto : Pagamento // O : é o mesmo que o extends no Java... a classe PagamentoBoleto extende a classse pagamento   (Herança)
{
    public string NumeroBoleto;


    public override void Pagar()
    {
        // regrado boleto aqui
    }
}

class PagamentoCartaoCredito : Pagamento
{
    public string Numero;

    public override void Pagar()
    {
        // regra do cartao de credito
    }
}
*/