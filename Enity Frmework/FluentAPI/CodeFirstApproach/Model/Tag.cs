using System.Collections.Generic;

namespace CodeFirstApproach.Model
{
    public class Tag
    {
        public Tag()
        {
            Courses = new List<Course>();
        }
        public int Id { get; set; }
        public ICollection<Course> Courses { get; set; }
        public string Name { get; set; }
       

    }

}
