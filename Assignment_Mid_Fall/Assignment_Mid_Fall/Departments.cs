using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_Fall
{
    class Departments
    {
        public string DepartmentName { get; set; }
        Course[] listOfCourses;
        public int totalCourse { get; set; }
        public Section Section { get; set; }

        public int CreditCount { get; set; }
        public Departments()
        {
            listOfCourses = new Course[100];
        }
        public Departments(string name)
        {
            DepartmentName = name;
            listOfCourses = new Course[100];
        }
        public void ShowInfo()
        {
            Console.WriteLine("Department: " + DepartmentName);
            Console.WriteLine("Total Courses: " + totalCourse);
        }
        public void AddCourse(params Course[] courses)
        {
            foreach (var course in courses)
            {
                if (totalCourse < 100)
                    listOfCourses[totalCourse++] = course;
            }
        }
        public void ShowAllCourses()
        {
            for (int i = 0; i < totalCourse; i++)
            {
                listOfCourses[i].ShowInfo();
                Console.WriteLine(" ");
            }
        }
    }
}
