﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class Candidate : IdentityUser
    {
        [Key]
        public string IdCandidate { get; set; }
        public string LastName { get; set; }        
        public string FirstName { get; set; }        
        public DateTime BirthDate { get; set; }        
        public string Sexe { get; set; }       
        public string HomePhone { get; set; }        
        public string CellPhone { get; set; }       
        public string FaxPhone { get; set; }      
        public string Image { get; set; }        
        public string Country { get; set; }       
        public string City { get; set; }       
        public string Address { get; set; }        
        public string Resume { get; set; }
        public string Email { get; set; }
       
    }
}