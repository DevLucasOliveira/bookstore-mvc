using BookStore.Context;
using BookStore.Domain;
using BookStore.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    [RoutePrefix("livros")]
    public class BookController : Controller
    {
        DataContext _context = new DataContext();


        public ActionResult Index()
        {
            return View(_context.Books.ToList());
        }


        [Route("criar")]
        public ActionResult Create()
        {
            ModelState.AddModelError("Mensagem", "Algum erro ocorreu");
            return View();
        }

        [Route("criar")]
        [HttpPost]
        public ActionResult Create(EditorBookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var category = _context.Categories.ToList();
                model.CategoryOptions = new SelectList(category, "Id", "Nome");
                return View(model);
            }
            var book = new Book();
            book.Name = model.Name;
            book.ISBN = model.ISBN;
            book.CreatedAt = model.CreatedAt;
            book.CategoryId = model.CategoryId;
            _context.Books.Add(book);
            _context.SaveChanges();

            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("Mensagem", ex.Message);
            }


            return RedirectToAction("Index");
        }

        [Route("editar")]
        public ActionResult Edit()
        {
            return View();
        }

        [Route("Editar")]
        [HttpPost]
        public ActionResult Edit(int id)
        {
            var book = _context.Books.Find(id);
            var model = new EditorBookViewModel
            {
                Name = book.Name,
                ISBN = book.ISBN,
                CategoryId = book.CategoryId
            };

            return View(model);
        }

    }
}