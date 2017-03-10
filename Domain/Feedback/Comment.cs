﻿using CodeReaction.Domain.Feedback;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReaction.Domain.Entities
{
    public class Comment : IAnnotation
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string User { get; set; }

        [Required]
        public long Revision { get; set; }

        public string File { get; set; }

        public string LineId { get; set; }

        public string Text { get; set; }

        [Required]
        public bool IsLike { get; set; }

        public long? ReplyToId { get; set; }
    }
}
