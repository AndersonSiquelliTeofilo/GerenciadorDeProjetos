using WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApp.Controllers
{
    public class TarefaController : Controller
    {
        private static List<Tarefa> tarefas = new List<Tarefa>();

        public IActionResult Index()
        {
            return View(tarefas);
        }

        [HttpGet]
        public IActionResult Inserir()  
        {
            return PartialView("_Inserir");
        }

        [HttpPost]
        public IActionResult Inserir(Tarefa tarefa)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Inserir", tarefa);
            }

            tarefas.Add(tarefa);

            return RedirectToAction(nameof(Index));
        }
    }
}
