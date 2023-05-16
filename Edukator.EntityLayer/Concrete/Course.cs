using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class Course
    {
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public int Review { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
        public List<CourseRegister> CourseRegisters { get; set; }
    }
}
