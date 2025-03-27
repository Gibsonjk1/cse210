using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{

    static void Main(string[] args)
    {
        static void CreateVideos()
        {
            List<Video> _videos = new List<Video>();

            Video video1 = new Video("Jimmy's Chicken Shack", "Bob Sanders", 637);
            Video video2 = new Video("Jimmy Eat World", "Santa Clause", 521);
            Video video3 = new Video("All American Boys", "Football Players Anonymous", 1235);
            Video video4 = new Video("Santa Clause is coming to town", "Snarky the Elf", 742);


            video1.AddComment("Emily Harper", "This video was so helpful, I learned so much!");
            video1.AddComment("Jackson Cruz", "I love the way you explained everything. Subscribed!");
            video1.AddComment("Ava Mitchell", "This was hilarious! I can’t stop laughing 😂");
            video2.AddComment("Liam Sullivan", "Wow, I didn’t know that! I’ll definitely try this next time.");
            video2.AddComment("Sophia Turner", "Such great content, keep it up! Can’t wait for more.");
            video2.AddComment("Noah Bennett", "This video gave me some serious motivation. Thanks for the inspiration!");
            video3.AddComment("Mia Anderson", "I had no idea this was a thing, but now I’m obsessed!");
            video3.AddComment("Mason Clark", "Bro, this was fire! Can’t wait to share it with my friends.");
            video3.AddComment("Isabella Garcia", "Totally relatable! I’ve been in this exact situation before.");
            video4.AddComment("James Walker", "You’ve earned a new subscriber! Love the style of your videos.");
            video4.AddComment("Olivia Roberts", "Such a good video, but I think you missed a small detail here.");
            video4.AddComment("Ethan Collins", "This is exactly what I needed to hear today, thanks for sharing!");

            _videos.Add(video1);
            _videos.Add(video2);
            _videos.Add(video3);
            _videos.Add(video4);

            foreach (Video video in _videos)
            {
                video.DisplayVideoContent();
            }
        }
        CreateVideos();
    }

}