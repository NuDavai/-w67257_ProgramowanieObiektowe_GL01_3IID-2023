using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Library.Repositories
{
    public class FileBookRepository : IBookRepository
    {
        private readonly string fileName = "books.json";

        public void Create(Book item)
        {
            var books = FileOperationHelper.ReadFile<List<Book>>(fileName);

            item.Id = books.Count + 1;
            books.Add(item);
            FileOperationHelper.WriteFile<List<Book>>(books, fileName);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Book Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAll()
        {
            return FileOperationHelper.ReadFile<List<Book>>(fileName);
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            throw new NotImplementedException();
        }

        public void Update(Book item)
        {
            throw new NotImplementedException();
        }
    }
}
