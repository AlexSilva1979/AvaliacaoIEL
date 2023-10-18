using AvaliacaoIEL.Models;
using Microsoft.EntityFrameworkCore;

namespace AvaliacaoIEL.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) :base(options) { }

        public DbSet<EstadoModel> Estados { get; set; }
        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<InstituicaoModel> Instituicoes { get; set; }
        public DbSet<AlunoModel> Alunos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }

    }
}
