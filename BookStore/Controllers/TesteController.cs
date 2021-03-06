﻿using BookStore.Domain;
using System.Web.Mvc;

namespace BookStore.Controllers
{

    [RoutePrefix("testes")]
    //[Route("{action=Dados}")]
    public class TesteController : Controller
    {
        
        public ViewResult Dados(int Id)
        {
            var autor = new Author { Id = 0, Name = "Lucas" };

            ViewBag.Category = "Produtos de Limpeza";
            ViewData["Category"] = "Produtos de Informática";
            TempData["Category"] = "Produtos de Escritório";
            Session["Category"] = "Móveis";

            return View(autor);
        }

        public string Index(int Id)
        {
            return $"Index do {Id}";
        }

        public JsonResult UmaAction(int? id, string nome)
        {
            var autor = new Author { Id = 0, Name = nome };

            return Json(autor);
        }

        [HttpPost]
        [ActionName("Autor")]
        public JsonResult ActionDois(Author author)
        {
            return Json(author);
        }

        [Route("minharota/{id}")]
       // [Route("~/minharota/{id}")]
        public string MinhaAction(int id)
        {
            return "Ok! cheguei na rota.";
        }

        [Route("minharota2/{categoria:alpha:minlength(3)}")]
        // [Route("~/minharota/{id}")]
        public string MinhaAction2(string categoria)
        {
            return $"Ok! cheguei na rota {categoria}";
        }

        [Route("minharota3/{estacao:values(primavera|verao|outono|inverno)}")]
        // [Route("~/minharota/{id}")]
        public string MinhaAction3(string estacao)
        {
            return $"Ola! estamos no {estacao}";
        }
    }
}