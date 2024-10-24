public class PacoteTuristico : IReservavel
{
    public string Codigo { get; set; }
    public string Descricao { get; set; }
    public int VagasDisponiveis { get; set; }

    public void Reservar()
    {
        if (VagasDisponiveis > 0)
        {
            VagasDisponiveis--;
            Console.WriteLine("Reserva realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Não há vagas disponíveis.");
        }
    }

    public void Cancelar()
    {
        VagasDisponiveis++;
        Console.WriteLine("Reserva cancelada com sucesso.");
    }
}
