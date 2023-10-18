using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Repositorio
{
    public class EstadoRepositorio
    {
        public static IEnumerable<EstadoModel> ListaUf()
        {
            List<EstadoModel> estados = new List<EstadoModel>();
            estados.Add(new EstadoModel(1, "Bahia"));
            estados.Add(new EstadoModel(2, "São Paulo"));
            estados.Add(new EstadoModel(3, "Rio de Janeiro"));
            estados.Add(new EstadoModel(4, "Minas Gerais"));
            return estados;

        }
    }
}
