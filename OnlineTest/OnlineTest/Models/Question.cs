﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineTest.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        public string Questionn { get; set; }
        public string CorrectAnswer { get; set; }
        public string Screenshot { get; set; }
        public int Expectedtime { get; set; }
        public int Score { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ICollection<Test> Tests { get; set; }



    }
}
