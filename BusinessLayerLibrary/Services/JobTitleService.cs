using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using BusinessLayerLibrary.Models;
using DataAccessLibrary.DbLayer;
using RepositoryLib;

namespace BusinessLayerLibrary.Services
{
    public class JobTitleService : GenericService<JobTitle, JobTitleDTO>
    {
        public JobTitleService(IGenericRepository<JobTitle> repository) : base(repository)
        {
        }

        protected override IMapper GetMapper()
        {
            return new MapperConfiguration(cfg => {
                cfg.AddExpressionMapping();
                cfg.CreateMap<JobTitle, JobTitleDTO>();
                cfg.CreateMap<JobTitleDTO, JobTitle>();
            }).CreateMapper();
        }
    }
}
