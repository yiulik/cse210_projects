using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        Video v1 = new Video("Video 1", "John", 124);
        Video v2 = new Video("Video 2", "Will", 942);
        Video v3 = new Video("Video 3", "Lily Chambers", 512);
        Video v4 = new Video("Video 4", "Barry", 264);
        videoList.Add(v1);
        videoList.Add(v2);
        videoList.Add(v3);
        videoList.Add(v4);

        v1.StoreComment(new Comment("Jolyne", "This video is great!"));
        v1.StoreComment(new Comment("JoJo", "This video is as bizarre as my name"));
        v1.StoreComment(new Comment("Jonathan", "I appreciate how much effort you have put in this video."));
        v1.StoreComment(new Comment("Joseph", "Thank you for making this video!"));

        v2.StoreComment(new Comment("JoJo", "This video is so boring..."));
        v2.StoreComment(new Comment("Tilly", "Umm..."));
        v2.StoreComment(new Comment("Jack", "What a guy..."));
        v2.StoreComment(new Comment("Willy", "This 15-min vid is trying to kill us with boredom..."));

        v3.StoreComment(new Comment("Jonathan", "I love how Thorfinn looks at Canute at 2:04"));
        v3.StoreComment(new Comment("Xmen", "I have watched this 100 times now"));
        v3.StoreComment(new Comment("Just a Guy", "The animation is just GREAT!!!!!!!!!!!!!"));
        v3.StoreComment(new Comment("Alvery", "Awesome fight"));

        v4.StoreComment(new Comment("Joseph", "Decent video"));
        v4.StoreComment(new Comment("Christ", "We need more videos like this"));
        v4.StoreComment(new Comment("Daniel", "Pretty good compilation"));
        v4.StoreComment(new Comment("Cristina", "Im glad I didnt waste my time here jaja"));

        foreach (Video video in videoList)
        {
            Console.WriteLine($"\nTitle: {video._title}\nAuthor: {video._author}\nLength: {video._length} seconds\nNumber of Comments: {video.ReturnComment(video.comments)}");
            Console.WriteLine("\nComments:");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }
        }
    }
}