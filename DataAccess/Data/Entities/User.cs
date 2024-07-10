using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data.Entities
{
    public class User
    {
        public int UserTypeId { get; set; }
        public UserType UserType { get; set; }
    }
}
