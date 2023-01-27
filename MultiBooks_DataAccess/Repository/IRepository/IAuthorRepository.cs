﻿using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBooks_DataAccess.Repository.IRepository
{
  public interface IAuthorRepository : IRepositoryAsync<Author>
  {
    void Update(Author author);
  }
}
