
using AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingProject.Domain.App.Entities;
using AutoMapper;

namespace AccountingProject.Persistance.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
             CreateMap<CreateCompanyRequest,Company>().ReverseMap();
        }
    }
}