using System;

class Program {
    static void Main(string[] args) {
        Agencia agencia = new Agencia();

        // Cadastrar um destino
        Destino destino1 = new Destino { NomeLocal = "Porto Alegre", Pais = "Brasil", Codigo = "POA01", Descricao = "Cidade bacana" };
        agencia.CadastrarDestino(destino1);

        // Listar destinos
        agencia.ListarDestinos();

        // Cadastrar um cliente
        Cliente cliente1 = new Cliente { Nome = "Paulo Henrique", NumeroIdentificacao = "81796431", Contato = "paulo@hotmail.com" };
        agencia.CadastrarCliente(cliente1);

        // Listar clientes
        agencia.ListarClientes();

        // Cadastrar um pacote
        PacoteTuristico pacote1 = new PacoteTuristico {
            Codigo = "PAC01",
            Descricao = "Pacote POA",
            VagasDisponiveis = 10 // Somente aqui, sem mais propriedades
        };
        agencia.CadastrarPacote(pacote1); // Certifique-se de que este método existe na classe Agencia

        // Listar pacotes
        agencia.ListarPacotes(); // Certifique-se de que este método existe na classe Agencia

        // Reservar um pacote
        pacote1.Reservar(); // Chama o método diretamente no pacote

        // Cancelar uma reserva
        pacote1.Cancelar(); // Chama o método diretamente no pacote

        // Listar pacotes novamente
        agencia.ListarPacotes(); // Certifique-se de que este método existe na classe Agencia
    }
}
