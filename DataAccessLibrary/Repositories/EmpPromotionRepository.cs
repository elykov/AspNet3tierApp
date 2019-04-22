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
    public class EmpPromotionRepository : GenericRepository<EmpPromotion>
    {
        public EmpPromotionRepository(DbContext context) : base(context)
        {
        }
    }
}
