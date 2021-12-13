using E_JOGOS.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_JOGOS.Controllers
{
    public class EquipeController : Controller
    {
        Equipe equipeModel = new Equipe();



        public IActionResult Index()
        {
            
            //Armazenar as informações do backend para serem acessadas no frontend
            ViewBag.Equipes = equipeModel.ReadAll();

            
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {

        }
    }
}
