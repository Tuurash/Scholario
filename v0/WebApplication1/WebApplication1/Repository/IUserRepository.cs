using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scholar.Models;

namespace WebApplication1.Repository
{
    interface IUserRepository : IRepository<userTB>
    {
        IEnumerable<userTB> GetMostPopular();
    }
}