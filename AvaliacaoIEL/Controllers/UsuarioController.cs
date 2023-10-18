using AvaliacaoIEL.Filters;
using AvaliacaoIEL.Models;
using AvaliacaoIEL.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoIEL.Controllers
{
    [PaginaUsuarioLogado]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            List<UsuarioModel> usuarios = _usuarioRepositorio.GetAll();
            return View(usuarios);
        }
        public IActionResult Criar()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Criar(UsuarioModel usuarioModel)
        {

            try
            {
                if (ModelState.IsValid)
                {   
                    usuarioModel.DataCadastro = DateTime.Now;
                    usuarioModel.SetSenhaHash();
                    _usuarioRepositorio.Adicionar(usuarioModel);
                    TempData["MensagemSucesso"] = "Registro salvo com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(usuarioModel);
            }
            catch (Exception ex)
            {

                TempData["MensagemErro"] = $"Ops, erro ao tentar salvar o registro, detalhe do erro:{ex.Message}";
                return View(usuarioModel);
            }

        }

    }
}
