public class Cliente {
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Contato { get; set; }

    public void ExibirInformacoes() 
    {
        Console.WriteLine("Nome: " + Nome);
        Console.WriteLine("ID: " + NumeroIdentificacao);
        Console.WriteLine("Contato: " + Contato);
    }
}
