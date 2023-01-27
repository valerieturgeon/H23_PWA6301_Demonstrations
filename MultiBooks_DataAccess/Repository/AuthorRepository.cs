﻿using MultiBooks_DataAccess.Data;
using MultiBooks_DataAccess.Repository.IRepository;
using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiBooks_DataAccess.Repository
{
  public class AuthorRepository : RepositoryAsync<Author>, IAuthorRepository
  {
    private readonly MultiBooksDbContext _db;

    public AuthorRepository(MultiBooksDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(Author author)
    {
      var dataFromDb = _db.Author.FirstOrDefault(s => s.Id == author.Id);

      if (dataFromDb != null)
      {
        dataFromDb.FirstName = author.FirstName;
        dataFromDb.LastName = author.LastName;
      }

    }
  }
}
