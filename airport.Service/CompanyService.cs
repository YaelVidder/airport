using airport.Core.Repositories;
using airport.Core.Services;
using airport.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace airport.Service
{
    public class CompanyService: ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        public List<Company> GetList()
        {
            return _companyRepository.GetAll();
        }
    }
}
