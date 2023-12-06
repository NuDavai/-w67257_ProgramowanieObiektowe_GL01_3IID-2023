using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface IBookRepository: IBaseRepository<Book, int>
    {

    }
}
