using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Model
{
    public class Course 
    {
        public Course()
        {
            Tags = new List<Tag>();
        }
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }

        public int AuthorId { get; set; }
        public Author Author { get; set; }// this is called navigation property
        public  ICollection<Tag> Tags  { get; set; }

        [ForeignKey("Cover")]
        public int CoverId { get; set; }
        public Cover Cover { get; set; }
    }
}
