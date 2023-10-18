using AvaliacaoIEL.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace AvaliacaoIEL.ViewComponents
{
    public class Menu : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string sessaoUsuario = HttpContext.Session.GetString("UsuarioLogado");
            if (string.IsNullOrEmpty(sessaoUsuario)) return null;

            UsuarioModel usuario = JsonConvert.DeserializeObject<UsuarioModel>(sessaoUsuario);

             return View(usuario);

        }
    }
}
