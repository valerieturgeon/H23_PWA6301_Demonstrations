﻿using Microsoft.AspNetCore.Mvc.Rendering;
using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBooks_Models.ViewModels
{
  public class AuthorsBooksVM
  {
    public AuthorBook AuthorBook { get; set; }
    public Book Book { get; set; }
    public IEnumerable<AuthorBook> BookAuthorList { get; set; }
    public IEnumerable<SelectListItem> AuthorList { get; set; }
  }
}
