using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class FeedBack
    {
        [Key]
        public int? Id { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public virtual User User { get; set; }
        public virtual Test Test { get; set; }
    }
}
