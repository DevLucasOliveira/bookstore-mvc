using BookStore.Domain;
using BookStore.Filters;
using BookStore.Repositories;
using BookStore.Repositories.Interfaces;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("autores")]
    //[LogActionFilter()]
    public class AuthorController : Controller
    {
        private IAuthorRepository repository;

        public AuthorController()
        {
            repository = new AuthorRepository();
        }

        [Route("listar")]
        //[LogActionFilter()]
        public ActionResult Index()
        {
            return View(repository.Get());
        }

        [Route("criar")]
        public ActionResult Create()
        {
            return View();
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(Author author)
        {
            if (repository.Create(author))
            {
                return RedirectToAction("Index");
            }
            return View(author);
        }

        [Route("editar/{id:int}")]
        public ActionResult Edit(int id)
        {
            return View(repository.Get(id));
        }

        [Route("editar/{id:int}")]
        [HttpPost]
        public ActionResult Edit(Author author)
        {
            if (repository.Update(author))
            {
                return RedirectToAction("Index");
            }
            return View(author);
        }

        [Route("excluir/{id:int}")]
        public ActionResult Delete(int id)
        {
            return View(repository.Get(id));
        }

        [Route("excluir/{id:int}")]
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult ConfirmDelete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}