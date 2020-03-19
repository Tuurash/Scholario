using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Scholar.Models;
using Scholar.Repository;

namespace WebApplication1.Repository
{
    public class CourseRepository : Repository<courseTB>, ICourseRepository
    {
        public IEnumerable<courseTB> GetMostPopular()
        {
            throw new NotImplementedException();
        }
    }

}