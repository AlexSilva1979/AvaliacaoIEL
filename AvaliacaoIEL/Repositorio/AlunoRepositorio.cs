using AvaliacaoIEL.Data;
using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public AlunoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        public AlunoModel Adicionar(AlunoModel aluno)
        {
            _bancoContext.Alunos.Add(aluno);
            _bancoContext.SaveChanges();
            return aluno;
        }

        
        public List<AlunoModel> GetAll()
        {
            return _bancoContext.Alunos.ToList();
        }

        public AlunoModel BuscarPorID(int id)
        {
            return _bancoContext.Alunos.FirstOrDefault(x => x.Id == id);
        }

        public bool Excluir(int id)
        {
            AlunoModel alunoModel = BuscarPorID(id);
            if (alunoModel == null) throw new Exception("Erro ao tentar excluir o registro");
            

            _bancoContext.Alunos.Remove(alunoModel);
            _bancoContext.SaveChanges();
            
            return true;


        }
    }
}

