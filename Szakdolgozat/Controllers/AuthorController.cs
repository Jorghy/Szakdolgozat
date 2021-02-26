using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Szakdolgozat.BL.UnitOfWork;
using Szakdolgozat.DTO.ViewModels;

namespace Szakdolgozat.Web.Controllers
{
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
            return View(authorsVm);
        }
    }
}
