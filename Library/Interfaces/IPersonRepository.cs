using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface IPersonRepository: IBaseRepository<Person, long>
    {
        List<Book> GetBorrowedBook(long id);
        void BorrowBook(long id, Book book);
    }
}
