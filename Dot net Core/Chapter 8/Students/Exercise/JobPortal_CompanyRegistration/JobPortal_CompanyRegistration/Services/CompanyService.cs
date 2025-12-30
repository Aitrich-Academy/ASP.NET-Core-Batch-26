using AutoMapper;
using JobPortal_CompanyRegistration.Dto_s;
using JobPortal_CompanyRegistration.Models;
using JobPortal_CompanyRegistration.Repositories;

namespace JobPortal_CompanyRegistration.Services
{
    public class CompanyService: ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            this.companyRepository = companyRepository;
            this.mapper = mapper;
        }
        public bool RegisterCompany(CompanyDto companyDto)
        {
            var company=mapper.Map<Company>(companyDto);
            return companyRepository.RegisterCompany(company);
        }
        public CompanyDto GetCompanyById(Guid companyId)
        {
            var company=companyRepository.GetCompanyById(companyId);
            return mapper.Map<CompanyDto>(company);
        }
    }
}
