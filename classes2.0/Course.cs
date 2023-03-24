using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes2._0
{
    public class Course
    {
        string _courseName;
        string _teacher;
        List<Student> _courseRoster = new List<Student>();
        //course 
        public Course(string courseName, string teacher)
        {
            _courseName = courseName;//name
            _teacher = teacher; //teacher
        }

        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Teacher { get => _teacher; set => _teacher = value; }
        public List<Student> CourseRoster { get => _courseRoster; }

        //methods
        public void EnrollStudent(Student student)
        {
            //adds the students
            _courseRoster.Add(student);

        }
        //find the average of the two grades
        public double RosterAverage()
        {
            //som equal to 0
            double sum = 0;
            foreach (Student student in _courseRoster)
            {
                //with student average
                sum += student.StudentAverage();
            }
            return sum / _courseRoster.Count;
        }

    }
}
