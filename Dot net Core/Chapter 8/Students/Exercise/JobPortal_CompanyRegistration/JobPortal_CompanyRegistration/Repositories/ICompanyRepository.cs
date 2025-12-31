using JobPortal_CompanyRegistration.Models;

namespace JobPortal_CompanyRegistration.Repositories
{
    public interface ICompanyRepository
    {
        public bool RegisterCompany(Company company);
        public Company GetCompanyById(Guid companyId);

    }
}
