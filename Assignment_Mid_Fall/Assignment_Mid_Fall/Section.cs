using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Mid_Fall
{
    class Section
    {
        private string sectionName;

        public string SectionName
        {
            get { return sectionName; }
            set { sectionName = value; }
        }

        private int sectionId;

        public int SectionId
        {
            get { return sectionId; }
            set { sectionId = value; }
        }

        private int secCount;

        public int SecCount
        {
            get { return secCount; }
            set { secCount = value; }
        }

        Course[] courseinfo;


        public Section()
        {
            courseinfo = new Course[10];

        }
        public Section(string sectionName, int sectionId)
        {
            this.sectionName = sectionName;
            this.sectionId = sectionId;
            courseinfo = new Course[10];
        }
        public void ShowInfo()

        {
            Console.WriteLine("Section: " + sectionName);
            Console.WriteLine("section ID: " + sectionId);
            for (int i = 0; i < secCount; i++)
            {
                courseinfo[i].ShowInfo();
            }

        }
    }
}
