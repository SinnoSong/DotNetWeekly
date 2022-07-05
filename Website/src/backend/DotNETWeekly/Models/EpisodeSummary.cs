﻿using System;

namespace DotNETWeekly.Models
{
    public class EpisodeSummary
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Digest { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
