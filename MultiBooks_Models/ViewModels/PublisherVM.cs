﻿using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBooks_Models.ViewModels
{
 public class PublisherVM
  {
    public Publisher Publisher { get; set; }
    public IEnumerable<Book> BooksList { get; set; }

  }
}