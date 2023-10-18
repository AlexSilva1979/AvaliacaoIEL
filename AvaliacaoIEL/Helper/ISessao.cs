using AvaliacaoIEL.Models;

namespace AvaliacaoIEL.Helper
{
    public interface ISessao
    {
        void CriarSessaoUsuario(UsuarioModel usuarioModel);

        void RemoverSessaoUsuario();

        UsuarioModel BuscarSessaoUsuario();

    }
}
