using CommonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model
{
    [Table("Student")]
    public class Student : Entity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Others { get; set; }
    }
}
