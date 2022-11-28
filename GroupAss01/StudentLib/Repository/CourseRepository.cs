using StudentLib.DataAcess;
using StudentLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLib.Repository
{
 public class CourseRepository:ICourseRepository
    {
        public void AddNew(Course course)
        {
            CourseDAO.Instance.AddNew(course);
        }

        public Course GetCourse(string id) => CourseDAO.Instance.GetCourseByID(id);


        public IEnumerable<Course> GetCourses() => CourseDAO.Instance.GetCourseList();


        public void Remove(string id)
        {
            CourseDAO.Instance.Remove(id);
        }

        public void Update(Course course)
        {
            CourseDAO.Instance.Update(course);
        }
    }
}
