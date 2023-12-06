using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Book : IEntity<int>, IHasCreationTime
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public string Title { get; set; }
        public string Autor { get; set; }
        public int PublishYear { get; set; }
    }
}
