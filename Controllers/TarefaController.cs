using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo_id.Models;

namespace Todo_id.Controllers
{
    public class TarefaController : Controller
    {
        //Lista Tarefas:
        
        private readonly ILogger<HomeController> _logger;

        [Authorize]
        public IActionResult adicionarTarefa(){

            return View();

        }

    
        [HttpPost]
        public IActionResult adicionarTarefa(Tarefa item){
            
            Dados.AdicionarTarefa(item);

            return RedirectToAction("Index","Home");

            
        }
    
    //------------------------------------------------------------------------------------
    // Editar Tarefa:

        [Authorize]
        public IActionResult EditarTarefa(int id){

            //var lista = Dados.ListaUmaTarefa(id);

            return View();
        }

        [HttpPost]
        public IActionResult EditarTarefa(Tarefa tarefa){
            
            
            Dados.EditarTarefa(tarefa);

            return RedirectToAction("Index","Home");
        }

        //------------------------------------------------------------------------------------
        // Status Tarefa:

        [Authorize]        
        public ActionResult StatusTarefa(int id){

            Dados.EditarStatusTarefa(id);
                
            return RedirectToAction("Index","Home");
        }

        //------------------------------------------------------------------------------------
        // Deletar Tarefa:

        [Authorize]
        public ActionResult RemoverTarefa(int id){
            
            Dados.RemoverTarefa(id);

            return RedirectToAction("Index","Home");
        }
    
    }
}