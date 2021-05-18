using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortifolioMVC.Models;
using Microsoft.AspNetCore.Http;

namespace PortifolioMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }  

        public IActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastro(Aula aula)
        {
            AulaRepository ar = new AulaRepository();
            ar.Insert(aula);
            return View("Confirmacao");
        }

        public IActionResult Lista()
        {   
            AulaRepository ar = new AulaRepository();
            List<Aula> aulas = ar.Query();
            return View(aulas);

        }

        public IActionResult Editar(int Id)
        {
            if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");
            AulaRepository ar = new AulaRepository();
            Aula aula = ar.BuscarPorId(Id);
            return View(aula);
        }
        
        [HttpPost]
        public IActionResult Editar(Aula aula)
        {
            if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");            
            AulaRepository ar = new AulaRepository();
            ar.Atualizar(aula);
            ViewBag.Mensagem = "Cadastro atualizado com sucesso!";
            return Redirect("Lista");
        }

        public IActionResult Remover(int Id)
        {
            if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");
             AulaRepository ar = new AulaRepository();
            ar.Remover(Id);
            return Redirect("Lista");           
        }

        public IActionResult Login(){
           return View();
       }

       [HttpPost]
       public IActionResult Login(Usuario u){
           UsuarioRepository ur = new UsuarioRepository();
           Usuario usuario = ur.QueryLogin(u);
           if(usuario != null)
           {
               ViewBag.Mensagem = "Você esta logado";
               HttpContext.Session.SetInt32("idusuario", usuario.idusuario);
               HttpContext.Session.SetString("login", usuario.login);
               HttpContext.Session.SetString("nomeusuario", usuario.nomeusuario);
               HttpContext.Session.SetString("tipousuario", usuario.tipousuario);
               return Redirect("Index");
               
           }
           else{
                ViewBag.Mensagem = "Falha no login";
               return View();
               
        }
                  

       }

       public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }   

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
