using System;
/*
In this example, the NewsPublisher class represents the publisher, and the NewsSubscriber class represents the subscriber. 
The NewsPublisher class raises the NewsArticlePublished event when a new article is published. 
The NewsSubscriber class subscribes to the event using the Subscribe method and unsubscribes using the Unsubscribe method. 
The OnNewsArticlePublished method in the NewsSubscriber class handles the received articles and displays them in the console.
*/
namespace PublisherSubscriberExample
{
    public class NewsArticleEventArgs : EventArgs
    {
        public string Title { get; }
        public string Content { get; }

        public NewsArticleEventArgs(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }

    public class NewsPublisher
    {
        public event EventHandler<NewsArticleEventArgs>? NewsArticlePublished;

        protected virtual void OnNewsArticlePublished(string title, string content)
        {
            NewsArticlePublished?.Invoke(this, new NewsArticleEventArgs(title, content));
        }

        public void PublishNewsArticle(string title, string content)
        {
            Console.WriteLine($"Publishing article: {title}");
            OnNewsArticlePublished(title, content);
        }
    }

    public class NewsSubscriber
    {
        public void Subscribe(NewsPublisher publisher)
        {
            publisher.NewsArticlePublished += OnNewsArticlePublished;
        }

        public void Unsubscribe(NewsPublisher publisher)
        {
            publisher.NewsArticlePublished -= OnNewsArticlePublished;
        }

        private void OnNewsArticlePublished(object? sender, NewsArticleEventArgs e)
        {
            Console.WriteLine($"Received news article:\nTitle: {e.Title}\nContent: {e.Content}\n");
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            NewsPublisher publisher = new NewsPublisher();
            NewsSubscriber subscriber = new NewsSubscriber();

            subscriber.Subscribe(publisher);

            publisher.PublishNewsArticle("Breaking News", "This is the content of the breaking news article.");
            publisher.PublishNewsArticle("Sports Update", "This is the content of the sports update article.");

            subscriber.Unsubscribe(publisher);
        }
    }
}
