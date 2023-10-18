using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Repositorio
{
    public class CidadeRepositorio
    {
        public static IList<CidadeModel> ListaCidade(string siglaEstado)
        {
            List<CidadeModel> cidades = new List<CidadeModel>();
            cidades.Add(new CidadeModel(1, "RJ", "Angra dos Reis"));
            cidades.Add(new CidadeModel(2, "RJ", "Rio de Janeiro"));
            cidades.Add(new CidadeModel(3, "RJ", "Barra Mansa"));
            cidades.Add(new CidadeModel(4, "SP", "São Paulo"));
            cidades.Add(new CidadeModel(5, "SP", "Sertãozinho"));
            cidades.Add(new CidadeModel(6, "SP", "Osasco"));
            cidades.Add(new CidadeModel(7, "MG", "Belo Horizonte"));
            cidades.Add(new CidadeModel(8, "MG", "Poços de Caldas"));
            cidades.Add(new CidadeModel(9, "MG", "Betim"));
            cidades.Add(new CidadeModel(9, "BA", "Salvador"));
            cidades.Add(new CidadeModel(9, "BA", "Canaçari"));
            cidades.Add(new CidadeModel(9, "BA", "Lauro de Freitas"));
            cidades.Add(new CidadeModel(9, "BA", "Feira de Santana"));
            return cidades.Where(x => x.SiglaEstado == siglaEstado).ToList();

        }
    }
}
