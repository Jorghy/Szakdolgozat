using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PublisherController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var publishers = _unitOfWork.Publishers.GetAll();
            var publisherVm = _mapper.Map<List<PublisherVm>>(publishers);
            ViewData["Message"] = TempData["Message"];
            return View(publisherVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var pub = _unitOfWork.Publishers.GetById(azon);
            if (pub == null)
                return NotFound();

            var pubVm = _mapper.Map<PublisherVm>(pub);
            return View(pubVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(PublisherVm form)
        {
            if (ModelState.IsValid)
            {
                PublisherCo formCo = _mapper.Map<PublisherCo>(form);
                _unitOfWork.Publishers.Add(formCo);
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
        public IActionResult Edit(PublisherVm form)
        {
            if (ModelState.IsValid)
            {
                PublisherCo pubCo = _mapper.Map<PublisherCo>(form);
                _unitOfWork.Publishers.Update(pubCo);
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
            var pubCo = _unitOfWork.Publishers.GetById(id);

            if (pubCo == null)
                return NotFound();

            var pubVm = _mapper.Map<PublisherVm>(pubCo);
            return View(pubVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var pubCo = _unitOfWork.Publishers.GetById(id);

            if (pubCo == null)
                return NotFound();

            var pubVm = _mapper.Map<PublisherVm>(pubCo);
            return View(pubVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var pubCo = _unitOfWork.Publishers.GetById(id);
            _unitOfWork.Publishers.Delete(pubCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
