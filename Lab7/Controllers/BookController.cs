using Library.Interfaces;
using Library.Models;
using Library.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Lab7.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet]
        public Book Get(int id)
        {
            return _bookRepository.Get(id);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }


        [HttpGet]
        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        [HttpPost]
        public void Create(Book input)
        {
            _bookRepository.Create(input);
        }

        [HttpPut]
        public void Update(Book input)
        {
            _bookRepository.Update(input);
        }

        [HttpGet]
        public List<Book> GetBooksByAuthor(string author)
        {
            return _bookRepository.GetBooksByAuthor(author);
        }

        [HttpGet]
        public List<Book> GetBooksByPublishYear(int year)
        {
            return _bookRepository.GetBooksByPublishYear(year);
        }

    }
}