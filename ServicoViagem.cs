public abstract class ServicoViagem {
    protected string Codigo { get; set; }
    protected string Descricao { get; set; }

    public abstract void Reservar();
    public abstract void Cancelar();
}
