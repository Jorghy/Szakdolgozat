using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    [Authorize]
    public class StoreController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public StoreController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var stores = _unitOfWork.Stores.GetAll();
            var storeVm = _mapper.Map<List<StoreVm>>(stores);
            ViewData["Message"] = TempData["Message"];
            return View(storeVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var store = _unitOfWork.Stores.GetById(azon);
            if (store == null)
                return NotFound();

            var storeVm = _mapper.Map<StoreVm>(store);
            return View(storeVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StoreVm form)
        {
            if (ModelState.IsValid)
            {
                Store formCo = _mapper.Map<Store>(form);
                _unitOfWork.Stores.Add(formCo);
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
        public IActionResult Edit(StoreVm form)
        {
            if (ModelState.IsValid)
            {
                Store storeCo = _mapper.Map<Store>(form);
                _unitOfWork.Stores.Update(storeCo);
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
            var storeCo = _unitOfWork.Stores.GetById(id);

            if (storeCo == null)
                return NotFound();

            var storeVm = _mapper.Map<StoreVm>(storeCo);
            return View(storeVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var storeCo = _unitOfWork.Stores.GetById(id);

            if (storeCo == null)
                return NotFound();

            var storeVm = _mapper.Map<StoreVm>(storeCo);
            return View(storeVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var storeCo = _unitOfWork.Stores.GetById(id);
            _unitOfWork.Stores.Delete(storeCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
