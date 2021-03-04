using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    public class SaleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SaleController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var sales = _unitOfWork.Sales.GetAll();
            var saleVm = _mapper.Map<List<SaleVm>>(sales);
            ViewData["Message"] = TempData["Message"];
            return View(saleVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            IEnumerable<SelectListItem> storeItems = new List<SelectListItem>();
            IEnumerable<SelectListItem> bookItems = new List<SelectListItem>();
            var stores = _unitOfWork.Stores.GetAll();
            var storeVm = _mapper.Map<IEnumerable<StoreVm>>(stores);
            storeItems = storeVm.Select(p => new SelectListItem
            {
                Text = p.StoreName,
                Value = p.StoreId.ToString()
            });
            var books = _unitOfWork.Books.GetAll();
            var bookVm = _mapper.Map<IEnumerable<BookVm>>(books);
            bookItems = bookVm.Select(p => new SelectListItem
            {
                Text = p.Title,
                Value = p.BookId.ToString()
            });

            ViewBag.Store = storeItems;
            ViewBag.Book = bookItems;

            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var sale = _unitOfWork.Sales.GetById(azon);
            if (sale == null)
                return NotFound();

            var saleVm = _mapper.Map<SaleVm>(sale);
            return View(saleVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SaleVm form)
        {
            if (ModelState.IsValid)
            {
                SaleCo formCo = _mapper.Map<SaleCo>(form);
                _unitOfWork.Sales.Add(formCo);
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
        public IActionResult Edit(SaleVm form)
        {
            if (ModelState.IsValid)
            {
                SaleCo saleCo = _mapper.Map<SaleCo>(form);
                _unitOfWork.Sales.Update(saleCo);
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
            var saleCo = _unitOfWork.Sales.GetById(id);

            if (saleCo == null)
                return NotFound();

            var saleVm = _mapper.Map<SaleVm>(saleCo);
            return View(saleVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var saleCo = _unitOfWork.Sales.GetById(id);

            if (saleCo == null)
                return NotFound();

            var saleVm = _mapper.Map<SaleVm>(saleCo);
            return View(saleVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var saleCo = _unitOfWork.Sales.GetById(id);
            _unitOfWork.Sales.Delete(saleCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
