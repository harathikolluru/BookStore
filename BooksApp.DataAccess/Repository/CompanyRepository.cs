using BooksApp.DataAccess.Repository.IRepository;
using BooksApp.Models;
using BooksAppWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksApp.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private ApplicationDbContext _db;
        public CompanyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Company obj)
        {
            _db.Companies.Update(obj);
        }
    }
}
