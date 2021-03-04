using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.Models;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
    public class JobController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public JobController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var jobs = _unitOfWork.Jobs.GetAll();
            var jobVm = _mapper.Map<List<JobVm>>(jobs);
            ViewData["Message"] = TempData["Message"];
            return View(jobVm);
        }

        #region Add
        public IActionResult Create(int? id)
        {
            if (id == null)
                return View();

            var azon = int.Parse(id.ToString());
            var job = _unitOfWork.Jobs.GetById(azon);
            if (job == null)
                return NotFound();

            var jobVm = _mapper.Map<JobVm>(job);
            return View(jobVm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(JobVm form)
        {
            if (ModelState.IsValid)
            {
                JobCo formCo = _mapper.Map<JobCo>(form);
                _unitOfWork.Jobs.Add(formCo);
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
        public IActionResult Edit(JobVm form)
        {
            if (ModelState.IsValid)
            {
                JobCo jobCo = _mapper.Map<JobCo>(form);
                _unitOfWork.Jobs.Update(jobCo);
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
            var jobCo = _unitOfWork.Jobs.GetById(id);

            if (jobCo == null)
                return NotFound();

            var jobVm = _mapper.Map<JobVm>(jobCo);
            return View(jobVm);
        }
        #endregion

        #region Delete
        public IActionResult Delete(int id)
        {
            var jobCo = _unitOfWork.Jobs.GetById(id);

            if (jobCo == null)
                return NotFound();

            var jobVm = _mapper.Map<JobVm>(jobCo);
            return View(jobVm);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var jobCo = _unitOfWork.Jobs.GetById(id);
            _unitOfWork.Jobs.Delete(jobCo);
            _unitOfWork.Complate();
            TempData["Message"] = "Sikeres törlés!";
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}
