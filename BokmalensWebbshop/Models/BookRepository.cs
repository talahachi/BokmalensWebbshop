﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BokmalensWebbshop.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> AllBooks
        {
            get
            {
                return _appDbContext.Books.Include(c => c.Category);
            }
        }

        public IEnumerable<Book> BooksOfTheWeek
        {
            get
            {
                return _appDbContext.Books.Include(c => c.Category).Where(p => p.IsBookOfTheWeek);
            }
        }

        public Book GetBookById(int bookId)
        {
            return _appDbContext.Books.FirstOrDefault(p => p.BookId == bookId);
        }
    }
}
