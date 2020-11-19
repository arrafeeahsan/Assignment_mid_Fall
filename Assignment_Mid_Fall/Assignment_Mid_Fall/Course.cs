using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_Fall
{
    class Course
    {
        public int Number { get; set; }
        private int courseId;

        public int CourseId { get; set; }
        private string courseName;

        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        private int courseCredit;

        public int CourseCredit
        {
            get { return courseCredit; }
            set { courseCredit = value; }
        }
        private double courseTeachingHours;

        public double CourseTeachingHours
        {
            get { return courseTeachingHours; }
            set { courseTeachingHours = value; }
        }


        private Section[] sections;
        private int sectionCount;

        public int SectionCount
        {
            get { return sectionCount; }
            set { sectionCount = value; }
        }

        public Course()
        {
            sections = new Section[10];
            sectionCount = 0;
        }
        public Course(string courseName, int courseId, int courseCredit, double courseTeachingHours)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;

            sections = new Section[10];
            sectionCount = 0;
        }
        public Course(string courseName, int courseId, int courseCredit, double courseTeachingHours, int Number)
        {
            this.courseName = courseName;
            this.courseId = courseId;
            this.courseCredit = courseCredit;
            this.courseTeachingHours = courseTeachingHours;
            this.Number = Number;
            sections = new Section[10];
            sectionCount = 0;
        }
        public void AddScetion(params Section[] sections)
        {
            foreach (var a in sections)
            {
                if (sectionCount < 20)
                {
                    this.sections[sectionCount++] = a;
                }
                else
                {
                    Console.WriteLine("Can not add more sections to the course: ");
                }
            }
        }
        public void ShowAllTheSections()
        {
            for (int i = 0; i < sectionCount; i++)
            {
                sections[i].ShowInfo();
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Course Name: " + courseName);
            Console.WriteLine("Course ID: " + courseId);
            Console.WriteLine("Course Credits: " + courseCredit);
            Console.WriteLine("Course Hours: " + courseTeachingHours);
            Console.WriteLine("");

        }
    }
}
