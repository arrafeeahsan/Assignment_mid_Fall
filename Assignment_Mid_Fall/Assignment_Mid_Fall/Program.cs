using System;

namespace Assignment_Mid_Fall
{
    class Program
    {
        static void Main(string[] args)
        {

            Departments dept = new Departments("Faculty of Science and Technology");
            Departments dept1 = new Departments("Faculty of Engineering");

            Course course = new Course("OOP", 403, 3, 5);
            Course course1 = new Course("OOP2", 503, 3, 5);
            Course course2 = new Course("Electrical Circuits 1", 311, 3, 6);
            Course course3 = new Course("Electrical Circuits 2", 411, 3, 6);
            Course course4 = new Course("Electronic Devices", 421, 3, 6);


            Console.WriteLine("Courses are added to the department");
            Console.WriteLine("---------------------------------------------");

            dept.AddCourse(course, course1);
            dept.ShowAllCourses();
            dept.ShowInfo();
            Console.WriteLine("---------------------------------------------");
            dept1.AddCourse(course2, course3, course4);
            dept1.ShowAllCourses();
            dept1.ShowInfo();
            Console.WriteLine("---------------------------------------------");

            Section sec = new Section("B1", 101);
            Section sec1 = new Section("B2", 102);
            Section sec2 = new Section("B3", 103);
            Section sec3 = new Section("B4", 104);
            Section sec4 = new Section("B5", 105);
            Section sec5 = new Section("B6", 106);
            Section sec6 = new Section("B7", 107);
            Section sec7 = new Section("B8", 108);
            Section sec8 = new Section("B9", 109);
            Section sec9 = new Section("B10", 110);

            course.AddScetion(sec, sec1, sec2, sec3, sec4, sec5, sec6);
            course.ShowAllTheSections();
            course.ShowInfo();

            Console.WriteLine("---------------------------------------------");

            course1.AddScetion(sec7, sec8, sec9);
            course1.ShowAllTheSections();
            course1.ShowInfo();

            Console.WriteLine("---------------------------------------------");
        }
    }
}
