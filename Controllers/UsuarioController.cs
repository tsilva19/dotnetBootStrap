using PortifolioMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Microsoft.AspNetCore.Http;
namespace PortifolioMVC.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastro()
       {
           if(HttpContext.Session.GetInt32("idusuario") == null)
            return RedirectToAction("Login");
             return View();
           
       }

       [HttpPost]
       public IActionResult Cadastro(Usuario usuario){
           if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");
           UsuarioRepository ur = new UsuarioRepository();
           ur.Insert(usuario);
           ViewBag.Mensagem = "Usuario Cadastrado com Sucesso";
           return View();
       }

        public IActionResult Editar(int Id)
        {
            if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");
             UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.BuscarPorId(Id);
            return Redirect("Listar");
        }

        [HttpPost]
        public IActionResult Editar(Usuario usuario)
        {
            if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");            
            UsuarioRepository ur = new UsuarioRepository();
            ur.Atualizar(usuario);
            ViewBag.Mensagem = "Usuario atualizado com sucesso!";
            return Redirect("Listar");
        }

        public IActionResult Listar(){
        
        //    if(HttpContext.Session.GetInt32("idUsuario") == null)
        //      return RedirectToAction("Login");
             UsuarioRepository ur = new UsuarioRepository();
                List<Usuario> usuarios = ur.Query();
                return View(usuarios);
         
       }

        public IActionResult Remover(int Id)
        {
            if(HttpContext.Session.GetInt32("idusuario") == null)
                return RedirectToAction("Login");
             UsuarioRepository ur = new UsuarioRepository();
            ur.Remover(Id);
            return Redirect("Listar");           
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
    }
}