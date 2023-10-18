using AvaliacaoIEL.Enums;
using AvaliacaoIEL.Helper;
using System.ComponentModel.DataAnnotations;

namespace AvaliacaoIEL.Models
{
    public class UsuarioModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O E-mail é obrigatório.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "A Senha é obrigatória.")]
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public PerfilEnum Perfil { get; set; }

        public bool SenhaValida(string senha)
        {

            return Senha == Criptografia.GerarHash(senha);

        }

        public void SetSenhaHash()
        {
            Senha = Criptografia.GerarHash(Senha);
        }
    }
}
