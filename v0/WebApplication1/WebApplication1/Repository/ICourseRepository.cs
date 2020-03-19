using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scholar.Models;

namespace WebApplication1.Repository
{
    interface ICourseRepository:IRepository<courseTB>
    {
        IEnumerable<courseTB> GetMostPopular();
    }
}