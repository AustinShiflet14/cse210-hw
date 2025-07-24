using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Top 10 Detail Fails", "AutoCarePro", 360);
        v1.AddComment(new Comment("John", "Great video!"));
        v1.AddComment(new Comment("Lily", "I love the editing."));
        v1.AddComment(new Comment("Mike", "This helped me a lot."));
        videos.Add(v1);

        Video v2 = new Video("Crystal Detailing Tips", "ShineMaster", 480);
        v2.AddComment(new Comment("Alex", "Nice tips, thank you!"));
        v2.AddComment(new Comment("Sara", "Clean and clear."));
        v2.AddComment(new Comment("Dave", "Subbed!"));
        videos.Add(v2);

        Video v3 = new Video("Mastering Interior Car Cleaning", "ShinyRides", 395);
        v3.AddComment(new Comment("Brianna", "This helped me clean my seats perfectly!"));
        v3.AddComment(new Comment("Mike", "What vacuum do you recommend?"));
        v3.AddComment(new Comment("Sandra", "Never thought to use a toothbrush—genius."));
        videos.Add(v3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($" - {c.Name}: {c.Text}");
            }
            Console.WriteLine();
        }
    }
}