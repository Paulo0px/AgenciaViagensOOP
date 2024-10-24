public class Destino : IPesquisavel
{
    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Destino: {NomeLocal}, País: {Pais}, Código: {Codigo}, Descrição: {Descricao}");
    }

    public void PesquisarPorCodigo(string codigo)
    {
        // Apenas compara os códigos de forma simples
        if (Codigo == codigo)
        {
            ExibirInformacoes();
        }
        else
        {
            Console.WriteLine("Destino não encontrado com esse código.");
        }
    }

    public void PesquisarPorNome(string nome)
    {
        // Compara diretamente os nomes
        if (NomeLocal == nome)
        {
            ExibirInformacoes();
        }
        else
        {
            Console.WriteLine("Destino não encontrado com esse nome.");
        }
    }
}
