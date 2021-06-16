using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    public class BookAuthorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookAuthorController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult CreateWithAuthor(string authorId)
        {
            var authors = _unitOfWork.Authors.GetById(Convert.ToInt32(authorId));
            var authorVm = _mapper.Map<AuthorVm>(authors);
            ViewBag.author = authorVm.FirstName + " " + authorVm.LastName;

            IEnumerable<SelectListItem> bookItems = new List<SelectListItem>();

            var books = _unitOfWork.Books.GetAll();
            var bookVm = _mapper.Map<IEnumerable<BookVm>>(books);
            bookItems = bookVm.Select(b => new SelectListItem
                {
                    Text = b.Title,
                    Value = b.Id.ToString()
                });
            ViewBag.book = bookItems;
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithAuthor(BookAuthorVm model)
        {
            if (ModelState.IsValid)
            {
                BookAuthor bookAuthor = _mapper.Map<BookAuthor>(model);
                _unitOfWork.BookAuthors.Add(bookAuthor);
                _unitOfWork.Complate();
                return RedirectToAction("Details", "Author", new { id = model.AuthorId });
            }
            return View(model);
        }

        public IActionResult CreateWithBook(string bookId)
        {
            IEnumerable<SelectListItem> authorItems = new List<SelectListItem>();
            var authors = _unitOfWork.Authors.GetAll();
            var authorVm = _mapper.Map<IEnumerable<AuthorVm>>(authors);
            authorItems = authorVm.Select(a => new SelectListItem
            {
                Text = a.LastName + " " + a.FirstName,
                Value = a.Id.ToString()
            });
            ViewBag.author = authorItems;

            var book = _unitOfWork.Books.GetById(Convert.ToInt32(bookId));
            var bookVm = _mapper.Map<BookVm>(book);
            ViewBag.book = bookVm.Title;

            return View();
        }

        [HttpPost]
        public IActionResult CreateWithBook(BookAuthorVm model)
        {
            if (ModelState.IsValid)
            {
                BookAuthor bookAuthor = _mapper.Map<BookAuthor>(model);
                _unitOfWork.BookAuthors.Add(bookAuthor);
                _unitOfWork.Complate();
                return RedirectToAction("Details", "Book", new { id = model.BookId });
            }
            return View(model);
        }

        public IActionResult Delete(int bookAuthorId)
        {
            ViewBag.Dest = ViewBag.Source;
            var bookAuthor = _unitOfWork.BookAuthors.GetById(bookAuthorId);

            if (bookAuthor == null)
                return NotFound();

            var authorVm = _mapper.Map<BookAuthorVm>(bookAuthor);
            return View(authorVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(BookAuthorVm model)
        {
            var bookAuthor = _unitOfWork.BookAuthors.GetById(model.Id);
            _unitOfWork.BookAuthors.Delete(bookAuthor);
            _unitOfWork.Complate();
            return RedirectToAction("Index", "Home");
        }        
    }
}
