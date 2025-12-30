using JobPortal_CompanyRegistration.Models;

namespace JobPortal_CompanyRegistration.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext context;
        public CompanyRepository(AppDbContext context)
        {
            this.context = context;
        }
        public bool RegisterCompany(Company company)
        {
            context.Companies.Add(company);
            context.SaveChanges();
            return true;
        }
        public Company GetCompanyById(Guid companyId)
        {
            return context.Companies.Find(companyId);
        }

    }
}
