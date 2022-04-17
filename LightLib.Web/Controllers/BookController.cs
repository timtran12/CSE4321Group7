using System.Threading.Tasks;
using LightLib.Models.DTOs.Assets;
using LightLib.Service.Books;
using LightLib.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LightLib.Web.Controllers
{
    public class BookController : Controller
    {

        IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;

        }

        [HttpPost]
        public async Task<bool> NewBook ([FromBody] BookDto book)
        {

            return await _bookService.Add(book);
        }

    }
}
