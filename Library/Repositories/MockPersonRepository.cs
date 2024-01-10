using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Repositories
{
    public class MockPersonRepository : IPersonRepository
    {
        private List<Person> data = new List<Person>();

        public void Create(Person item)
        {
            item.Id = data.Count + 1;
            data.Add(item);
        }

        public List<Person> GetAll()
        {
            return data;
        }


        public void Delete(long id)
        {
            data.RemoveAll(x => x.Id == id);
        }

        public Person Get(long id)
        {
            return data.Find(x => x.Id == id);
        }


        public void Update(Person item)
        {
            var index = data.FindIndex(x => x.Id == item.Id);

            if (index > -1)
                data[index] = item;
        }

        public void BorrowBook(long id, Book book)
        {
            var person = Get(id);
            if (person == null)
                return;

            person.BorrowedBooks.Add(book);
        }

        public List<Book> GetBorrowedBook(long id)
        {
            return Get(id)?.BorrowedBooks ?? new List<Book>();
        }
    }
}
