using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        
        [ForeignKey(nameof(Department))]
        public int DepatmentId { get; set; }
        public string BloudGroup { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        public int EnrollmentNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }

        public Department Department { get; set; }
        public Student()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
    }
}
