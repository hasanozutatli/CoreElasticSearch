﻿using MyBlogProject.Core.Entities;
using MyBlogProject.Entites.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyBlogProject.Entities.Models
{
    public class Post : IEntity
    {
        //[NotMapped]
        //public  Guid ObjectId { get { return Guid.NewGuid(); } }
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public int ReadCount { get; set; }

        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public User User { get; set; }
        public List<Tag> PostTags { get; set; }
    }
}