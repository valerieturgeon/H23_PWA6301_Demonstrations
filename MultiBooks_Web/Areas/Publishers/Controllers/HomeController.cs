using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MultiBooks_DataAccess.Repository.IRepository;
using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MultiBooks.Areas.Publishers.Controllers
{
  [Area("Publishers")]
  public class HomeController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<HomeController> _logger;

    public HomeController(IUnitOfWork unitOfWork, ILogger<HomeController> logger)
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
