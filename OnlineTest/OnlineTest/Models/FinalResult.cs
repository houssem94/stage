using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class FinalResult
    {
        [Key]
        public int Id { get; set; }
        public int TotalScore { get; set; }
        public DateTime Duration { get; set; }
    }
}
