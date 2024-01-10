using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Person : IEntity<long>, IHasCreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> BorrowedBooks { get; set; } = new List<Book>();
    }
}
