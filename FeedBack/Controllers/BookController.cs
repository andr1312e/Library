using Lib.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lib.Controllers
{
    public class BookController : Controller
    {
        private IBookSetter BookRepository;
        public BookController(IBookSetter BookSetter)
        {
            BookRepository = BookSetter;
        }
        public ViewResult List() => View(BookRepository.Books);
    }
}
