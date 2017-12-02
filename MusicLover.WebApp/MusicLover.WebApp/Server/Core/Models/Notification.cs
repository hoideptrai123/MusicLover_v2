﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MusicLover.WebApp.Server.Core.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public NotificationType NotificationType { get; set; }
        public DateTime? OriginalDateTime { get; set; }
        public string OriginalVenue { get; set; }
        [Required]
        public Gig Gig { get; set; }
    }
}
