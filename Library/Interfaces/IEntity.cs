using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Interfaces
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
