using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using BusinessLayerLibrary.Models;
using DataAccessLibrary.DbLayer;
using RepositoryLib;

namespace BusinessLayerLibrary.Services
{
    public class EmpPromotionService : GenericService<EmpPromotion, EmpPromotionDTO>
    {
        public EmpPromotionService(IGenericRepository<EmpPromotion> repository) : base(repository)
        {
        }

        protected override IMapper GetMapper()
        {
            return new MapperConfiguration(cfg => {
                cfg.AddExpressionMapping();
                cfg.CreateMap<EmpPromotion, EmpPromotionDTO>().
                ForMember("FullName", opt => opt.MapFrom(sm => $"{sm.Employee.FirstName} {sm.Employee.LastName}")).
                ForMember("JobTitle", opt => opt.MapFrom(sm => sm.JobTitle.NameJobTitle ));

                //.ForMember("LastName", opt => opt.MapFrom(str => str.Employee.LastName))
                //.ForMember("SubdivisionName", opt => opt.MapFrom(sdv => sdv.));

                cfg.CreateMap<EmpPromotionDTO, EmpPromotion>();
            }).CreateMapper();
        }
    }
}
