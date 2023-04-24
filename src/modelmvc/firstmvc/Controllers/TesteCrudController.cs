using System;
using firstmvc.Database;
using firstmvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace firstmvc.Controllers
{
    public class TesteCrudController : Controller
    {

        private readonly MeuDbContext _contexto;

        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }

        public IActionResult Index()
        {
            var aluno = new Aluno
            {
                Nome = "Eduardo",
                DataNascimento = DateTime.Now,
                Email = "eduardo@eduardopires.net.br"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno2 = _contexto.Alunos.Find(aluno.Id);
            var aluno3 = _contexto.Alunos.FirstOrDefault(a => a.Email == "eduardo@eduardopires.net.br");
            var aluno4 = _contexto.Alunos.Where(a => a.Nome == "Eduardo");

            aluno.Nome = "João";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            return View("_Layout");
        }
    }

}