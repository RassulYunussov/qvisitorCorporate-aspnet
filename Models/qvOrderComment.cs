﻿using qvisitorCorp.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace qvisitorCorp.Models
{
    [Table ("qvOrderComment")]
    public class qvOrderComment
    {
        public int Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public string Comment { get; set; }
        public DateTime CommentDate { get; set; }

        public qvOrderComment() { }
    }
}
