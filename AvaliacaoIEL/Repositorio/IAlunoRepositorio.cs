using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Repositorio
{
    public interface IAlunoRepositorio
    {
        List<AlunoModel> GetAll();
        AlunoModel BuscarPorID(int id);

        AlunoModel Adicionar(AlunoModel aluno);
        
        bool Excluir(int id);
    }
}
