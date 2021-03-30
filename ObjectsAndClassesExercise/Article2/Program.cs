using System;

namespace Article2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    namespace Articles
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                int n = int.Parse(Console.ReadLine());
                List<Article> articles = new List<Article>();

                for (int i = 1; i <= n; i++)
                {
                    string input = Console.ReadLine();
                    string[] elements = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                    Article article = new Article(elements[0], elements[1], elements[2]);
                    articles.Add(article);
                }

                string sortWord = Console.ReadLine();

                if (sortWord == "title")
                {
                    foreach (Article article in articles.OrderBy(a => a.Title))
                    {
                        Console.WriteLine(article.ToString());
                    }
                }
                else if (sortWord == "content")
                {
                    foreach (Article article in articles.OrderBy(a => a.Content))
                    {
                        Console.WriteLine(article.ToString());
                    }
                }
                else if (sortWord == "author")
                {
                    foreach (Article article in articles.OrderBy(a => a.Author))
                    {
                        Console.WriteLine(article.ToString());
                    }
                }

               


            }
        }

        public class Article
        {
            public string Title { get; set; }

            public string Content { get; set; }

            public string Author { get; set; }

            public Article(string title, string content, string author)
            {
                this.Title = title;
                this.Content = content;
                this.Author = author;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }

        }
    }



}
