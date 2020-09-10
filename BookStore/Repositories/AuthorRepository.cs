using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace BookStore.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private DataContext _context = new DataContext();

        public bool Create(Author author)
        {
            try
            {
                _context.Authores.Add(author);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Delete(int id)
        {
            var author = _context.Authores.Find(id);
            _context.Authores.Remove(author);
            _context.SaveChanges();
        }

        public List<Author> Get()
        {
            return _context.Authores.ToList();
        }

        public Author Get(int id)
        {
            return _context.Authores.Find(id);
        }

        public List<Author> GetByName(string name)
        {
            return _context.Authores.AsNoTracking().Where(x => x.Name.Contains(name)).ToList();
        }

        public bool Update(Author author)
        {
            try
            {
                _context.Entry<Author>(author).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public void Dispose()
        {
            _context.Dispose();
        }


    }
}