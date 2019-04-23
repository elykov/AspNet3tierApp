using DataAccessLibrary.DbLayer;
using RepositoryLib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repositories
{
    public class JobTitleRepository : GenericRepository<JobTitle>
    {
        public JobTitleRepository(DbContext context) : base(context)
        {
        }
    }
}
