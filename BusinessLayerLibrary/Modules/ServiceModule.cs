using Autofac;
using BusinessLayerLibrary.Models;
using BusinessLayerLibrary.Services;
using DataAccessLibrary.DbLayer;
using DataAccessLibrary.Repositories;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerLibrary.Modules
{
    public class ServiceModule : Module
    {
        //void SetDependencies<TypeService, GenericServiceDTO, TypeRepository, GenericRepositoryType>(ContainerBuilder builder)
        //{
        //    builder.RegisterType(typeof(TypeService))
        //                     .As(typeof(GenericServiceDTO));

        //    builder.RegisterType(typeof(TypeRepository))
        //                     .As(typeof(GenericRepositoryType));
        //}

        protected override void Load(ContainerBuilder builder)
        {
            // EmpPromotion
            //SetDependencies<EmpPromotionService, IGenericService<EmpPromotionDTO>, 
            //    EmpPromotionRepository, IGenericRepository<EmpPromotion>>
            //        (builder);

            // EmpPromotion
            builder.RegisterType(typeof(EmpPromotionService))
                         .As(typeof(IGenericService<EmpPromotionDTO>));
            builder.RegisterType(typeof(EmpPromotionRepository))
                      .As(typeof(IGenericRepository<EmpPromotion>));

            // Employee
            builder.RegisterType(typeof(EmployeeService))
                        .As(typeof(IGenericService<EmployeeDTO>));
            builder.RegisterType(typeof(EmployeeRepository))
                      .As(typeof(IGenericRepository<Employee>));

            // JobTitle
            builder.RegisterType(typeof(JobTitleService))
                       .As(typeof(IGenericService<JobTitleDTO>));
            builder.RegisterType(typeof(JobTitleRepository))
                      .As(typeof(IGenericRepository<JobTitle>));

            builder.RegisterType(typeof(HrContext))
                     .As(typeof(DbContext)).InstancePerLifetimeScope();
        }
    }
}