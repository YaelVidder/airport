using airport.Core.Repositories;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Data.Repositories
{
    public class CompanyRepository: ICompanyRepository
    {
        public readonly DataContext _context;

        public CompanyRepository(DataContext context)
        {
            _context = context;
        }
        public List<Company> GetAll()
        {
            return _context.companies.ToList();
        }

        public Company GetById(int id)
        {
            return _context.companies.FirstOrDefault(c => c.companyId == id);
        }

    }
}
