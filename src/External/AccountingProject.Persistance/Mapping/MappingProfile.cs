
using AccountingProject.Application.Features.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using AccountingProject.Application.Features.CompanyFeatures.CreateUCAF;
using AccountingProject.Application.Features.RoleFeatures.CreateRole;
using AccountingProject.Domain.App.Entities;
using AccountingProject.Domain.App.Entities.Identity;
using AccountingProject.Domain.CompanyEntities;
using AutoMapper;

namespace AccountingProject.Persistance.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
             CreateMap<CreateCompanyRequest,Company>().ReverseMap();
             CreateMap<CreateUCAFRequest,UniformChartOfAccount>().ReverseMap();
             CreateMap<CreateRoleRequest,AppRole>().ReverseMap();
        }
    }
}