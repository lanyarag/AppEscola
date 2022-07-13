using AppEscola.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppEscola.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            List<Aluno> alunos = new List<Aluno>();
            alunos.Add(new Aluno()
            {
                Id = 1,
                Nome = "Willian",
                Sobrenome = "Sant Anna",
                Status = "Reprovado"
            }) ;

            alunos.Add(new Aluno()
            {
                Id = 2,
                Nome = "Thiago",
                Sobrenome = "Machado",
                Status = "Aprovado"
            });

            alunos.Add(new Aluno()
            {
                Id = 3,
                Nome = "Rodrigo",
                Sobrenome = "Braga",
                Status = "Aprovado"
            });           
            
            alunos.Add(new Aluno()
            {
                Id = 4,
                Nome = "Caroline",
                Sobrenome = "Da Silva",
                Status = "Recuperação"
            });
            
            return View(alunos);
        }
    }
}




