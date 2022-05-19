﻿namespace AspNetIdentity.Model
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string AspNetIdentityUserId { get; set; }
        public Category Category { get; set; }
    }
}
