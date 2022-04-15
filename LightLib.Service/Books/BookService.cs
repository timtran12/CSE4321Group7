using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using LightLib.Data;
using LightLib.Data.Models.Assets;
using LightLib.Models;
using LightLib.Models.DTOs.Assets;
using LightLib.Service.Interfaces;

namespace LightLib.Service.Books
{
    public class BookService : IBookService
    {

        private readonly LibraryDbContext _context;
        private readonly IMapper _mapper;

        public BookService(
            LibraryDbContext context,
            IMapper mapper
        )
        {
            _context = context;
            _mapper = mapper;
        }


        public async Task<bool> Add(BookDto book)
        {
            var newBook = _mapper.Map<Book>(book);
            await _context.AddAsync(newBook);
            await _context.SaveChangesAsync();
            return true;

        }

        public Task<BookDto> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResult<BookDto>> GetAll(int page, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResult<BookDto>> GetByAuthor(string author, int page, int perPage)
        {
            throw new NotImplementedException();
        }

        public Task<BookDto> GetByIsbn(string isbn)
        {
            throw new NotImplementedException();
        }
    }
}
