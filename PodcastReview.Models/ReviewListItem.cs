﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodcastReview.Models
{
    public class ReviewListItem
    {
        public int ReviewId { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Podcast")]
        public string PodcastTitle { get; set; }

        [Display(Name = "Review")]
        public string Content { get; set; }

        private int ContentLimit = 100;

        public string ContentTrimmed
        {
            get
            {
                if (this.Content.Length > this.ContentLimit)
                    return this.Content.Substring(0, this.ContentLimit) + "...";
                else
                    return this.Content;
            }

        }

        public int Rating { get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => PodcastTitle;
    }
}
