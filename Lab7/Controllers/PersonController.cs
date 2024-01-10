using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Interfaces;
using Library.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab7.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        [HttpGet]
        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        [HttpPost]
        public void BorrowBook(long id, Book book)
        {
            _personRepository.BorrowBook(id, book);
        }

        [HttpGet]
        public List<Book> GetBorrowedBook(long id)
        {
            return _personRepository.GetBorrowedBook(id);
        }

        [HttpGet]
        public Person Get(long id)
        {
            return _personRepository.Get(id);
        }

        [HttpPost]
        public void Create(Person person)
        {
            _personRepository.Create(person);
        }

        [HttpPut]
        public void Update(Person person)
        {
            _personRepository.Update(person);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }
    }
}