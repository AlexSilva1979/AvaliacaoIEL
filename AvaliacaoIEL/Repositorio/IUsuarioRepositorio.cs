using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Repositorio
{
    public interface IUsuarioRepositorio
    {
        UsuarioModel BuscarPorEmail(string email);
        List<UsuarioModel> GetAll();
        UsuarioModel BuscarPorID(int id);

        UsuarioModel Adicionar(UsuarioModel aluno);
        
        bool Excluir(int id);
    }
}
