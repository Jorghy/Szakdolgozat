using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    public class RoleController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RoleController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var roles = _unitOfWork.Roles.GetAll();
            var roleVm = _mapper.Map<List<RoleVm>>(roles);
            ViewData["Message"] = TempData["Message"];
            return View(roleVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var role = _unitOfWork.Roles.GetById(azon);
            if (role == null)
                return NotFound();

            var roleVm = _mapper.Map<RoleVm>(role);
            return View(roleVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RoleVm form)
        {
            if (ModelState.IsValid)
            {
                RoleCo formCo = _mapper.Map<RoleCo>(form);
                _unitOfWork.Roles.Add(formCo);
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
        public IActionResult Edit(RoleVm form)
        {
            if (ModelState.IsValid)
            {
                RoleCo roleCo = _mapper.Map<RoleCo>(form);
                _unitOfWork.Roles.Update(roleCo);
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
            var roleCo = _unitOfWork.Roles.GetById(id);

            if (roleCo == null)
                return NotFound();

            var roleVm = _mapper.Map<RoleVm>(roleCo);
            return View(roleVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var roleCo = _unitOfWork.Roles.GetById(id);

            if (roleCo == null)
                return NotFound();

            var roleVm = _mapper.Map<RoleVm>(roleCo);
            return View(roleVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var roleCo = _unitOfWork.Roles.GetById(id);
            _unitOfWork.Roles.Delete(roleCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
