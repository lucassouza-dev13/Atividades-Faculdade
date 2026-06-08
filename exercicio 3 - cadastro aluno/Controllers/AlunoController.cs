using Microsoft.AspNetCore.Mvc;
using CadastroAluno.Models;

namespace CadastroAluno.Controllers
{
    public class AlunoController : Controller
    {
        // GET: /Aluno/Cadastrar
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        // POST: /Aluno/Cadastrar
        [HttpPost]
        public IActionResult Cadastrar(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            return RedirectToAction("Confirmacao", aluno);
        }

        // GET: /Aluno/Confirmacao
        public IActionResult Confirmacao(Aluno aluno)
        {
            return View(aluno);
        }
    }
}