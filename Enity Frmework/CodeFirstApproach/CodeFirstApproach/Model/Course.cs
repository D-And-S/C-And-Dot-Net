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

        [Required]
        [MaxLength(255)]
        public string Name{ get; set; }

        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public  ICollection<Tag> Tags  { get; set; }

        [ForeignKey("CoursePrice")]
        public int CoursePriceId { get; set; }
        public CoursePrice CoursePrice { get; set; }
    }


    

  

}
