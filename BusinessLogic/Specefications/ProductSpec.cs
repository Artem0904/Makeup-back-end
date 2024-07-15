using Ardalis.Specification;
using DataAccess.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BusinessLogic.Specefications
{
    public static class ProductSpecs
    {
        public class ById : Specification<Product>
        {
            public ById(int id)
            {
                Query
                    .Where(x => x.Id == id)
                    .Include(x => x.Category)
                    .Include(x => x.Brand)
                    .Include(x => x.Gender);
            }
        }
        public class All : Specification<Product>
        {
            public All()
            {
                Query.Include(x => x.Category)
                     .Include(x => x.Brand)
                     .Include(x => x.Gender);
            }
        }
        public class ByIds : Specification<Product>
        {
            public ByIds(IEnumerable<int> ids)
            {
                Query
                    .Where(x => ids.Contains(x.Id))
                    .Include(x => x.Category)
                    .Include(x => x.Brand)
                    .Include(x => x.Gender);
            }
        }
    }
}
