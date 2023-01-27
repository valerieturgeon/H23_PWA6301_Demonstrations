using MultiBooks_DataAccess.Data;
using MultiBooks_DataAccess.Repository;
using MultiBooks_DataAccess.Repository.IRepository;
using MultiBooks_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyBook_DataAccess.Repository
{
  public class AuthorBookRepository : RepositoryAsync<AuthorBook>, IAuthorBookRepository
  {
    private readonly MultiBooksDbContext _db;

    public AuthorBookRepository(MultiBooksDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(AuthorBook authorBook)
    {
      _db.Update(authorBook);

    }
  }
}
