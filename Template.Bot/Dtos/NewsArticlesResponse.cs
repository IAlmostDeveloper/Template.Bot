﻿namespace Template.Bot.Dtos.Responses
{
    public record struct NewsArticlesResponse
    {
        public string Status { get; set; }
        public int TotalResults { get; set; }
        public List<NewsArticle> Articles { get; set; }
    }
}
