using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;


namespace DemoMVC.Controllers
{

    public class HomeController : Controller
    {
        /*private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }*/
        

        public IActionResult Index(/*int id, string categoria*/)
        {
            /*var filme = new Filme
            {
                Titulo = "Coloscterol",
                DataLancamento = DateTime.Now,
                Genero = "Besteirol",
                Avaliacao = 1,
                Valor = 1000,
            };
            
            return RedirectToAction("Privacy", filme); */

            return View();
        }


        public IActionResult Privacy()
        {
            /*if (ModelState.IsValid)
            {

            }
            
            foreach (var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            */

            return View(); 


            /*var fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\eduar\Desktop\doc.txt");
            var fileName = "documento.txt"; 
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName)*/
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
