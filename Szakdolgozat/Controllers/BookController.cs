using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Szakdolgozat.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BookController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var books = _unitOfWork.Books.GetAll();
            var bookVm = _mapper.Map<List<BookVm>>(books);
            ViewData["Message"] = TempData["Message"];
            return View(bookVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var book = _unitOfWork.Books.GetById(azon);
            if (book == null)
                return NotFound();

            var bookVm = _mapper.Map<BookVm>(book);
            return View(bookVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(BookVm form)
        {
            if (ModelState.IsValid)
            {
                BookCo formCo = _mapper.Map<BookCo>(form);
                _unitOfWork.Books.Add(formCo);
                _unitOfWork.Complate();
                TempData["Message"] = "Sikeres hozzáadás!";
                return RedirectToAction(nameof(Index));
            }
            return View(form);
        }
        #endregion

        #region Edit
        public IActionResult Edit(int id)
        {
            return RedirectToAction(nameof(Create), new { id = id });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(BookVm form)
        {
            if (ModelState.IsValid)
            {
                BookCo bookCo = _mapper.Map<BookCo>(form);
                _unitOfWork.Books.Update(bookCo);
                _unitOfWork.Complate();

                TempData["Message"] = "A változtatásokat sikeresen elmentettük!";
                return RedirectToAction(nameof(Index));
            }
            return View(form);
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            var bookCo = _unitOfWork.Books.GetById(id);

            if (bookCo == null)
                return NotFound();

            var bookVm = _mapper.Map<BookVm>(bookCo);
            return View(bookVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var bookCo = _unitOfWork.Books.GetById(id);

            if (bookCo == null)
                return NotFound();

            var bookVm = _mapper.Map<BookVm>(bookCo);
            return View(bookVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var bookCo = _unitOfWork.Books.GetById(id);
            _unitOfWork.Books.Delete(bookCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
