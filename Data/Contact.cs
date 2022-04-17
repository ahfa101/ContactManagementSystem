using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Used for the annotation KEY
using System.Linq;
using System.Threading.Tasks;

namespace ContactManagementApp.Data
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        
    }
}
