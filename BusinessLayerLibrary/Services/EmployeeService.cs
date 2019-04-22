using AutoMapper;
using AutoMapper.Extensions.ExpressionMapping;
using BusinessLayerLibrary.Models;
using DataAccessLibrary.DbLayer;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Services
{
    public class EmployeeService : GenericService<Employee, EmployeeDTO>
    {
        public EmployeeService(IGenericRepository<Employee> repository) : base(repository)
        {
        }

        protected override IMapper GetMapper()
        {
            return new MapperConfiguration(cfg => {
                cfg.AddExpressionMapping();
                cfg.CreateMap<Employee, EmployeeDTO>();
                cfg.CreateMap<EmployeeDTO, Employee>();
            }).CreateMapper();
        }
    }
}
