using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Article article = new Article(elements[0], elements[1], elements[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string command = Console.ReadLine();
                string[] commands = command.Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1]);  
                }
                else if (commands[0] == "Rename")
                {
                    article.Rename(commands[1]);
                }
            }

            Console.WriteLine(article.ToString());

            
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

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}
