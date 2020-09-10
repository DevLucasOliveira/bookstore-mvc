using BookStore.Domain;
using System;
using System.Collections.Generic;

namespace BookStore.Repositories.Interfaces
{
    public interface IAuthorRepository : IDisposable
    {
        List<Author> Get();
        Author Get(int id);
        List<Author> GetByName(string name);
        bool Create(Author author);
        bool Update(Author author);
        void Delete(int id);
    }
}