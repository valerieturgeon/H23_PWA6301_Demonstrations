using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiBooks_DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultiBooks.Areas.Authors.Controllers
{
    [Area("Authors")]
    public class AuthorController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<AuthorController> _logger;

    public AuthorController(IUnitOfWork unitOfWork, ILogger<AuthorController> logger)
    {
      _unitOfWork = unitOfWork;
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }
  }
}
