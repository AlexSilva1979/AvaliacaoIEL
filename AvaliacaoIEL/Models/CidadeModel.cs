using Microsoft.AspNetCore.Mvc.Rendering;

namespace AvaliacaoIEL.Models
{
    public class CidadeModel
    {
        public CidadeModel(int Id, string SiglaEstado, string NomeCidade)
        {
            
        }
        public int Id { get; set; }
        public string? NomeCidade  { get; set; }
        public string? SiglaEstado { get; set; }

        

    }
}
