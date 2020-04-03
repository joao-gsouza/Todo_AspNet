using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Todo_id.Models;

namespace Todo_id.Controllers
{
    public class UsuarioController : Controller
    {
        //Lista Usuários:
        private List<Usuario> usuarios = new List<Usuario>();
        private readonly ILogger<HomeController> _logger;

       //------------------------------------------------------------------------------------
       // Adicionar Usuário:

       [HttpPost]
       [ValidateAntiForgeryToken]
       public IActionResult adicionarUsuario(Usuario usuario){
            
            usuario.Id = 0;
            
            if(usuarios.Count() > 0){
            
            usuarios.Add(usuario);
            usuario.Id = usuarios.Select(m => m.Id).Max() + 1;

            }
            else{
                Console.WriteLine("Operação inválida!");
            }

            return RedirectToAction("Index");

        }
    }
}