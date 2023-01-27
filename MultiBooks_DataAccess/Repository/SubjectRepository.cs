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
  public class SubjectRepository : RepositoryAsync<Subject>, ISubjectRepository
  {
    private readonly MultiBooksDbContext _db;

    public SubjectRepository(MultiBooksDbContext db) : base(db)
    {
      _db = db;
    }

    public void Update(Subject subject)
    {
      _db.Update(subject);
    }
  }
}
