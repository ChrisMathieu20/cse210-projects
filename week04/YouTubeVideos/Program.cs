using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video("How to Cook Pasta", "Chef Luigi", 300);
        video1.AddComment(new Comment("Anna", "Thanks! This helped a lot"));
        video1.AddComment(new Comment("Marco", "Looks delicious."));
        video1.AddComment(new Comment("Sophie", "Can you make a video about sauces?"));

        Video video2 = new Video("Introduction to C#", "CodeMaster", 600);
        video2.AddComment(new Comment("John", "Great explanation."));
        video2.AddComment(new Comment("Emma", "I love how clear this is."));
        video2.AddComment(new Comment("Tom", "Please make one on LINQ."));

        Video video3 = new Video("Yoga for Beginners", "ZenWithJen", 420);
        video3.AddComment(new Comment("Lucy", "Feeling relaxed already."));
        video3.AddComment(new Comment("Mike", "Perfect for my morning routine."));
        video3.AddComment(new Comment("Nina", "Thanks Jen!"));
        
        Video video4 = new Video("Top 10 Travel Destinations", "WanderlustWorld", 480);
        video4.AddComment(new Comment("Alex", "Adding all of these to my list!"));
        video4.AddComment(new Comment("Karen", "Great visuals."));
        video4.AddComment(new Comment("Rob", "Can you include hotel suggestions next time?"));

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach (Video video in _videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._lengthInSecond} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}