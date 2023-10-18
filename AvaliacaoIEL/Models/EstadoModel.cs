namespace AvaliacaoIEL.Models
{
    public class EstadoModel
    {
        public EstadoModel(int Id, string NomeEstado)
        {
            this.Id = Id;
            this.NomeEstado = NomeEstado;
        }
        public int Id { get; set; }
        
        public string? NomeEstado { get; set; }
        public string? SiglaEstado { get; set; }

    }
}
