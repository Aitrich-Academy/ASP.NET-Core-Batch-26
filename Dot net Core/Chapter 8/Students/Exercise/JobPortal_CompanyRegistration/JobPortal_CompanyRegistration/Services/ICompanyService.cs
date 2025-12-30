using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;
using System.ComponentModel.Design;

namespace JobPortal_CompanyRegistration.Services
{
    public interface ICompanyService
    {
        public bool RegisterCompany(CompanyDto companyDto);  
       public CompanyDto GetCompanyById(Guid companyId);
    }
}
