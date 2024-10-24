public class Agencia
{
    public List<Destino> Destinos { get; set; } = new List<Destino>();
    public List<Cliente> Clientes { get; set; } = new List<Cliente>();
    public List<PacoteTuristico> Pacotes { get; set; } = new List<PacoteTuristico>();

    public void CadastrarDestino(Destino destino)
    {
        if (destino != null)
        {
            Destinos.Add(destino);
            Console.WriteLine("Destino cadastrado!");
        }
        else
        {
            Console.WriteLine("Destino não pode ser nulo.");
        }
    }

    public void ListarDestinos()
    {
        if (Destinos.Count == 0)
        {
            Console.WriteLine("Nenhum destino cadastrado.");
        }
        else
        {
            foreach (var destino in Destinos)
            {
                destino.ExibirInformacoes();
            }
        }
    }

    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente != null)
        {
            Clientes.Add(cliente);
            Console.WriteLine("Cliente cadastrado!");
        }
        else
        {
            Console.WriteLine("Cliente não pode ser nulo.");
        }
    }

    public void ListarClientes()
    {
        if (Clientes.Count == 0)
        {
            Console.WriteLine("Nenhum cliente cadastrado.");
        }
        else
        {
            foreach (var cliente in Clientes)
            {
                cliente.ExibirInformacoes();
            }
        }
    }

    // Método para cadastrar pacotes
    public void CadastrarPacote(PacoteTuristico pacote)
    {
        if (pacote != null)
        {
            Pacotes.Add(pacote);
            Console.WriteLine("Pacote cadastrado!");
        }
        else
        {
            Console.WriteLine("Pacote não pode ser nulo.");
        }
    }

    // Método para listar pacotes
    public void ListarPacotes()
    {
        if (Pacotes.Count == 0)
        {
            Console.WriteLine("Nenhum pacote cadastrado.");
        }
        else
        {
            foreach (var pacote in Pacotes)
            {
                Console.WriteLine($"Pacote: {pacote.Codigo}, Descrição: {pacote.Descricao}, Vagas disponíveis: {pacote.VagasDisponiveis}");
            }
        }
    }
}
