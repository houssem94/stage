using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OnlineTest.Models
{
    public class UserQA
    {
        [Key]
        public int Id { get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
        
    }
}
