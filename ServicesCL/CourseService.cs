using EntitiesCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesCL
{
    public class CourseService : ICourseService
    {
        public Course GetCourseByID(long courseID)
        {
            return new Course
            {
                CourseID = courseID,
                Description = "Demo course description",
                InstitutionID = 1,
                Title = "Demo Course Title"
            };
        }
    }
}
