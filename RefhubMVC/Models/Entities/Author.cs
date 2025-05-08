﻿namespace RefhubMVC.Models.Entities
{
    public class Author
    {

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Slug { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
