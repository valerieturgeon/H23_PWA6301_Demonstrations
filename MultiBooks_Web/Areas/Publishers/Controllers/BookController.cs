﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MultiBooks_Models;
using MultiBooks_DataAccess.Data;
using MultiBooks_Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using MultiBooks_DataAccess.Repository.IRepository;
using Microsoft.Extensions.Logging;
using MultiBooks_Models.Models;

namespace MultiBooks.Areas.Admin.Controllers
{
  [Area("Publishers")]
  public class BookController : Controller
  {
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BookController> _logger;

    public BookController(IUnitOfWork unitOfWork, ILogger<BookController> logger)
    {
      _unitOfWork = unitOfWork;
      _logger = logger;
    }
    public async Task<IActionResult> Index()
    {
      IEnumerable<Book> bookList = await _unitOfWork.Book.GetAllAsync(includeProperties: "Publisher,Subject,AuthorsBooks");

      return View(bookList);
    }

    //GET CREATE
    public async Task<IActionResult> Create()
    {
      IEnumerable<Subject> SubList = await _unitOfWork.Subject.GetAllAsync();

      IEnumerable<Publisher> PubList = await _unitOfWork.Publisher.GetAllAsync();

      BookVM bookVM = new BookVM()
      {
        Book = new Book(),
        SubjectList = SubList.Select(i => new SelectListItem
        {
          Text = i.Name,
          Value = i.Id.ToString()
        }),
        PublisherList = PubList.Select(i => new SelectListItem
        {
          Text = i.Name,
          Value = i.Id.ToString()
        })
      };
      return View(bookVM);
    }

    //POST CREATE
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(BookVM bookVM)
    {
      if (ModelState.IsValid)
      {
        // Ajouter à la BD
       await _unitOfWork.Book.AddAsync(bookVM.Book);
      }

      _unitOfWork.Save();
      return RedirectToAction(nameof(Index));
    }

    // GET EDIT
    public async Task<IActionResult> Update(int id)
    {
      IEnumerable<Subject> SubList = await _unitOfWork.Subject.GetAllAsync();

      IEnumerable<Publisher> PubList = await _unitOfWork.Publisher.GetAllAsync();

      BookVM bookVM = new BookVM()
      {
        Book = new Book(),
        SubjectList = SubList.Select(i => new SelectListItem
        {
          Text = i.Name,
          Value = i.Id.ToString()
        }),
        PublisherList = PubList.Select(i => new SelectListItem
        {
          Text = i.Name,
          Value = i.Id.ToString()
        })
      };
      bookVM.Book = await _unitOfWork.Book.FirstOrDefaultAsync(b => b.Id == id);
      if (bookVM == null)
      {
        return NotFound();
      }
      return View(bookVM);
    }

    // POST EDIT
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update(BookVM bookVM)
    {
      if (bookVM.Book.Id == 0)
      {
        //this is create
        await _unitOfWork.Book.AddAsync(bookVM.Book);
      }
      else
      {
        //this is an update
        _unitOfWork.Book.Update(bookVM.Book);
      }
      _unitOfWork.Save();
      return RedirectToAction(nameof(Index));
    }


  }
}
