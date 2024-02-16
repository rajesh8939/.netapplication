using System;
using System.Collections.Generic;

namespace NewspaperApp
{
    class Article
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string Content { get; set; }

        public Article(string title, string author, DateTime publishDate, string content)
        {
            Title = title;
            Author = author;
            PublishDate = publishDate;
            Content = content;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publish Date: {PublishDate}");
            Console.WriteLine($"Content: {Content}");
            Console.WriteLine();
        }
    }

    class Newspaper
    {
        private List<Article> articles = new List<Article>();

        public void AddArticle(Article article)
        {
            articles.Add(article);
        }

        public void DisplayArticles()
        {
            foreach (var article in articles)
            {
                article.Display();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a newspaper instance
            var newspaper = new Newspaper();

            // Add some articles
            newspaper.AddArticle(new Article("World News", "John Doe", DateTime.Now, "Content of world news article..."));
            newspaper.AddArticle(new Article("Sports News", "Jane Smith", DateTime.Now, "Content of sports news article..."));
            newspaper.AddArticle(new Article("Technology News", "Alice Johnson", DateTime.Now, "Content of technology news article..."));

            // Display all articles
            newspaper.DisplayArticles();
        }
    }
}
