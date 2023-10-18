using AvaliacaoIEL.Data;
using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContext _bancoContext;
        public UsuarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public UsuarioModel Adicionar(UsuarioModel Usuario)
        {
            _bancoContext.Usuarios.Add(Usuario);
            _bancoContext.SaveChanges();
            return Usuario;
        }

        
        public List<UsuarioModel> GetAll()
        {
            return _bancoContext.Usuarios.ToList();
        }

        public UsuarioModel BuscarPorEmail(string email)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Email.ToUpper() == email.ToUpper());
        }

        public UsuarioModel BuscarPorID(int id)
        {
            return _bancoContext.Usuarios.FirstOrDefault(x => x.Id == id);
        }

        public bool Excluir(int id)
        {
            UsuarioModel UsuarioModel = BuscarPorID(id);
            if (UsuarioModel == null) throw new Exception("Erro ao tentar excluir o registro");
            

            _bancoContext.Usuarios.Remove(UsuarioModel);
            _bancoContext.SaveChanges();
            
            return true;


        }

        
    }
}

