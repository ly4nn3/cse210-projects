using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        List<Video> videos = new List<Video>();

        Video video1 = new Video("British Rappers Fly to Korea to try Louis Vuitton Beef BBQ!", "Korean Englishman", 801.0f);
        video1.AddComment(new Comment("wxlurker", "I love that the cameramen get fed while filming"));
        video1.AddComment(new Comment("princeshortie7907", "I am absolutely loving the way that chef is responding."));
        video1.AddComment(new Comment("aciNetuc", "You can tell how they love the food so much that they literally fell silent... and this is Barney and Issaac we're talking about."));
        videos.Add(video1);

        Video video2 = new Video("Testing TikTok Food Trends | 2025", "Sorted Food", 1119.5f);
        video2.AddComment(new Comment("LuckyTondi", "Barry immediately going for saffron is 100% Barry."));
        video2.AddComment(new Comment("zeldeerskine3462", "In Germany, onions are usually filled with some sort of minced meat, a grain (usually rice now but pearl barley a hundred plus years ago), and just about any spice you can get your hands on. This was traditionally a wartime recipe."));
        video2.AddComment(new Comment("JudgementalToucan", "I'm glad Mike brought up his flying cereal dish because its immediately what I thought of when I saw the thumbnail."));
        video2.AddComment(new Comment("aidi58", "The Sang Har Mee needs to be fried a larger pan or wok so more oil can be scooped up to fry the flying bit. Poor Mike was having trouble getting enough hot oil to do the job properly."));
        videos.Add(video2);

        Video video3 = new Video("I Watched Every Barbie Movie Ever Made", "Ted Nivison", 6515.0f);
        video3.AddComment(new Comment("ianyates2965", "The fact that the theory makes total sense while at the same time having no relation to the live action movie is so perfect its indescribable"));
        video3.AddComment(new Comment("mckennaisaperson4058", "Ted slowly transitioning from referring to Barbie as “she” to “it” added a whole other layer of crazy to the theory breakdown, and I loved every second of it"));
        video3.AddComment(new Comment("MewDenise", "Barbie was advertized as an actress in the classic movies. That's why they were titled 'Barbie AS Rapunzel' or 'Barbie IN the nutcracker'"));
        videos.Add(video3);
    
        foreach (Video video in videos)
        {
            Console.WriteLine($"\nVideo: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of comments: {video.CountComments()}");

            Console.WriteLine("---------");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"@{comment.GetName()}\n  {comment.GetText()}");
            }
            Console.WriteLine("---------");
        }
    }
}