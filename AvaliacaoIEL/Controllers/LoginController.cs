using AvaliacaoIEL.Helper;
using AvaliacaoIEL.Models;
using AvaliacaoIEL.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AvaliacaoIEL.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly ISessao _sessao;
        public LoginController(IUsuarioRepositorio usuarioRepositorio,
            ISessao sessao)
        {
            _usuarioRepositorio = usuarioRepositorio;
            _sessao = sessao;
        }
        public IActionResult Index()
        {
            //Se o usuario está logado, redireciona para a lista de estudantes
            if(_sessao.BuscarSessaoUsuario() !=null) return RedirectToAction("Index", "Aluno");
            return View();
        }
        public IActionResult Sair()
        {
            _sessao.RemoverSessaoUsuario();
            return RedirectToAction("Index", "Login");
        }
            [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    UsuarioModel usuarioModel = _usuarioRepositorio.BuscarPorEmail(loginModel.Email);
                    if (usuarioModel != null) {
                        if (usuarioModel.SenhaValida(loginModel.Senha)) {
                            _sessao.CriarSessaoUsuario(usuarioModel);
                            return RedirectToAction("Index", "Aluno");
                        }
                        else
                        {
                            TempData["MensagemErro"] = "Senha inválido. Tente novamente.";
                        }
                    }
                    else
                    {
                        TempData["MensagemErro"] = "Usuário e/ou senha inválido. Tente novamente.";
                    }
                    
                }

                return View("Index");
            }
            catch (Exception ex)
            { 

                TempData["MensagemErro"] = $"Ops, erro ao tentar logar no sistema, detalhe do erro:{ex.Message}";
                return View("Index");
            }

        }
    }
}
