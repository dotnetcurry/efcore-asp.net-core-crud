using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebApi_With_EFCore.Models;
using WebApi_With_EFCore.Repositories;

namespace WebApi_With_EFCore.Controllers
{
    [Route("api/[controller]")]
    public class BookAPIController : Controller
    {
        IDataAccess<Book, int> _bookRepo;
        public BookAPIController(IDataAccess<Book, int> b)
        {
            _bookRepo = b;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            var books = _bookRepo.GetBooks();
            return books;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookRepo.GetBook(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]Book b)
        {
            int res = _bookRepo.AddBook(b);
            if (res != 0)
            {
                return Ok();
            }
            return Forbid();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Book b)
        {
            if (id == b.Id)
            {
               int res =  _bookRepo.UpdateBook(id,b);
                if (res != 0)
                {
                    return Ok(res);
                }
                return NotFound();
            }
            return NotFound();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int res = _bookRepo.DeleteBook(id);
            if (res != 0)
            {
                return Ok();
            }
            return NotFound();
        }
    }
}
