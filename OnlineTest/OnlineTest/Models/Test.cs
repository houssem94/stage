﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace OnlineTest.Models
{
    public class Test
    {
        [Key]
        public int? Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Level Level { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; }
        public float Minscore { get; set; }
        
        public virtual ICollection<FeedBack> Feedbacks { get; set; }
        public virtual User User { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<FinalResult> FinalResult { get; set; }
        

    }   
}
