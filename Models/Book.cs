using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        
        [ForeignKey(nameof(Department))]
        public int DepatmentId { get; set; }

        public Department Department { get; set; }


        public Book()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }
    }
}
