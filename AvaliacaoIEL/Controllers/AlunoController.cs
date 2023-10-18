using AvaliacaoIEL.Filters;
using AvaliacaoIEL.Models;
using AvaliacaoIEL.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AvaliacaoIEL.Controllers
{
    [PaginaUsuarioLogado]
    public class AlunoController : Controller
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        public AlunoController(IAlunoRepositorio alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
        }
        public IActionResult Index()
        {
            ViewData["Estados"] = new SelectList(EstadoRepositorio.ListaUf(), "SiglaEstado", "NomeEstado");
            View("criar");

            List<AlunoModel> alunos =  _alunoRepositorio.GetAll();
            return View(alunos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Excluir()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Criar(AlunoModel alunoModel) {

            try
            {
                if (ModelState.IsValid)
                {
                    _alunoRepositorio.Adicionar(alunoModel);
                    TempData["MensagemSucesso"] = "Registro salvo com sucesso!";
                    return RedirectToAction("Index");
                }

                return View(alunoModel);
            }
            catch (Exception ex)
            {

                TempData["MensagemErro"] = $"Ops, erro ao tentar salvar o registro, detalhe do erro:{ex.Message}";
                return View(alunoModel);
            }
            
        }

        public IActionResult Delete(int id)
        {

            try
            {   
                
                _alunoRepositorio.Excluir(id);
                TempData["MensagemSucesso"] = "Registro excluido com sucesso!";
                return RedirectToAction("Index");
                
            }
            catch (Exception ex)
            {

                TempData["MensagemErro"] = $"Ops, erro ao tentar excluir o registro, detalhe do erro:{ex.Message}";
                return RedirectToAction("Index");
            }

        }
    }

}
