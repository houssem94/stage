using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class User : IdentityUser
    {
        [Key]
        public string IdUser { get; set; }
        public string LastName { get; set; }        
        public string FirstName { get; set; }        
        public DateTime BirthDate { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Gender { get; set; }       
        public string HomePhone { get; set; }        
        public string CellPhone { get; set; }       
        public string FaxPhone { get; set; }      
        public string Image { get; set; }              
        public string Email { get; set; }
      
        public string ConfirmPassword { get; set; }
        public virtual ICollection<FeedBack> FeedBacks { get; set; }
        public virtual ICollection<Test> Tests { get; set; }
        public virtual ICollection<FinalResult> FinalResults { get; set; }
        public virtual ICollection<UserQA> UserQAs { get; set; }

       
    }
}
