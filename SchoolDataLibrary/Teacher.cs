using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SchoolDataLibrary
{
    public class Teacher
    {
        public virtual string Name { get; set; }
        public string SubjectTaught { get; set; }
        public Teacher(string name, string subjectTaught)
        {
            Name = name;
            SubjectTaught = subjectTaught;
        }
        public string GetTeacherInfo()
        {
            return $"{Name} teaches {SubjectTaught}";
        }
    }
}
