using AvaliacaoIEL.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace AvaliacaoIEL.Helper
{
    public class Sessao : ISessao
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessao(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;   
        }
        public UsuarioModel BuscarSessaoUsuario()
        {
            string sessaoUsuario = _httpContext.HttpContext.Session.GetString("UsuarioLogado");

            if (string.IsNullOrEmpty(sessaoUsuario)) return null;
            return JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);
        }

        public void CriarSessaoUsuario(UsuarioModel usuarioModel)
        {
            string valor = JsonConvert.SerializeObject(usuarioModel);

            _httpContext.HttpContext.Session.SetString("UsuarioLogado", valor);
        }

        public void RemoverSessaoUsuario()
        {
            _httpContext.HttpContext.Session.Remove("UsuarioLogado");
        }
    }
}
