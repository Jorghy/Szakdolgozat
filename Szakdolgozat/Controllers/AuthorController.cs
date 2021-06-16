using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AuthorController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var authors = _unitOfWork.Authors.GetAll();
            var authorsVm = _mapper.Map<List<AuthorVm>>(authors);
            ViewData["Message"] = TempData["Message"];
            return View(authorsVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var author = _unitOfWork.Authors.GetById(azon);
            if (author == null)
                return NotFound();

            var authorVm = _mapper.Map<AuthorVm>(author);
            return View(authorVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AuthorVm form)
        {
            if (ModelState.IsValid)
            {
                Author formCo = _mapper.Map<Author>(form);
                _unitOfWork.Authors.Add(formCo);
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
        public IActionResult Edit(AuthorVm form)
        {
            if (ModelState.IsValid)
            {
                Author authorCo = _mapper.Map<Author>(form);
                try
                {
                    _unitOfWork.Authors.Update(authorCo);
                    _unitOfWork.Complate();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (_unitOfWork.Authors.GetById(authorCo.Id) == null)
                        return NotFound();
                }
                TempData["Message"] = "A változtatásokat sikeresen elmentettük!";
                return RedirectToAction(nameof(Index));
            }
            return View(form);
        }
        #endregion

        #region Details
        public IActionResult Details(int id)
        {
            var authorCo = _unitOfWork.Authors.GetById(id);

            if (authorCo == null)
                return NotFound();

            var authorVm = _mapper.Map<AuthorVm>(authorCo);
            return View(authorVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var authorCo = _unitOfWork.Authors.GetById(id);

            if (authorCo == null)
                return NotFound();

            var authorVm = _mapper.Map<AuthorVm>(authorCo);
            return View(authorVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var authorCo = _unitOfWork.Authors.GetById(id);
            _unitOfWork.Authors.Delete(authorCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
