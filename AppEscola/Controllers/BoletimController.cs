using AppEscola.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppEscola.Controllers
{
    public class BoletimController : Controller
    {
        public IActionResult Boletim()
        {
            List<Boletim> boletim = new List<Boletim>();
            boletim.Add(new Boletim()
            {
                Materia = "Portugues",
                Nota1 = 5,
                Nota2 = 6.5,
                Nota3 = 6.5,
                Nota4 = 0,
                Status = "Reprovado"
            });

            boletim.Add(new Boletim()
            {
                Materia = "Matemática",
                Nota1 = 10,
                Nota2 = 8,
                Nota3 = 8,
                Nota4 = 8,
                Status = "Aprovado"
            });

            boletim.Add(new Boletim()
            {
                Materia = "Ciências",
                Nota1 = 6,
                Nota2 = 7.5,
                Nota3 = 8,
                Nota4 = 8,
                Status = "Aprovado"
            });

            boletim.Add(new Boletim()
            {
                Materia = "História",
                Nota1 = 8,
                Nota2 = 9,
                Nota3 = 10,
                Nota4 = 7.5,
                Status = "Aprovado"
            });

            return View(boletim);
        }
    }
}
