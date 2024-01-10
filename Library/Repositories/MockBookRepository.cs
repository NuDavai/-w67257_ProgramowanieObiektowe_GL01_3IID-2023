using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Repositories
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> data = new List<Book>() { new Book() { Title = "Tesr", Id = 1} };

        public void Create(Book item)
        {
            item.Id = data.Count + 1;
            data.Add(item);
        }

        public List<Book> GetAll()
        {
            return data;
        }


        public void Delete(int id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public Book Get(int id)
        {
            return data.Find(x => x.Id == id);
        }

       
        public void Update(Book item)
        {
            var index = data.FindIndex(x => x.Id == item.Id);
            
            if (index > -1)
                data[index] = item;
        }

        public List<Book> GetBooksByAuthor(string author)
        {
            return data.Where(x => x.Author == author).ToList();
        }

        public List<Book> GetBooksByPublishYear(int year)
        {
            return data.Where(x => x.PublishYear == year).ToList();
        }
    }
}
