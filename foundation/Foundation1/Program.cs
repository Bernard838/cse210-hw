using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create some videos
        var video1 = new Video("How to Learn C#", "Alex Diaz", 300);
        var video2 = new Video("Why I Love God", "Marysa Pedro", 400);
        var video3 = new Video("How To Pray", "Mc Kein", 600);

        // Adding the comments to the videos
        video1.Comments.Add(new Comment("Catore_bb", "Wow than was a great tutorial!"));
        video1.Comments.Add(new Comment("Akos_esi", "I love it and was very helpful, thanks."));
        video1.Comments.Add(new Comment("Mary", "Very educative and I've learned a lot."));

        video2.Comments.Add(new Comment("Jones A.B", "Thank you for letting me know the important of God in my life."));
        video2.Comments.Add(new Comment("Mawusi", "Excellent explanation."));

        video3.Comments.Add(new Comment("Eli", "Thank you now I can pray."));
        video3.Comments.Add(new Comment("Aghaley_7", "Loved the examples!"));
        video3.Comments.Add(new Comment("Mac Y", "This was amazing, thank you!"));
        video3.Comments.Add(new Comment("Lui_09", "Fantastic content."));

        // Storing the videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Displaying the information for each video
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"@ {comment.CommenterName}: {comment.CommentText}");
            }
            Console.WriteLine();
        }
    }
}
