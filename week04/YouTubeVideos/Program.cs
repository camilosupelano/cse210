using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("How to survive college", "Camilo Supelano", 500);
        Video video2 = new Video("Not dreaming with programming", "Edison Perez", 370);
        Video video3 = new Video("How to cook without fire", "Dallin Allen", 260);
        Video video4 = new Video("Stay awake the whole general conference", "Jeffrey Holland", 600);

        video1.AddComment(new Comment("Cristian","Nice tips, now I am prepared for next semester"));
        video1.AddComment(new Comment("Daniel","I wish I knew this when I was studying"));
        video1.AddComment(new Comment("Deborah","I don't think this actually works"));

        video2.AddComment(new Comment("Christopher","Who else is dreaming with loops"));
        video2.AddComment(new Comment("Melisa","Programming is so easy"));
        video2.AddComment(new Comment("Andrew","Get a girlfriend"));

        video3.AddComment(new Comment("Camila","How is it even possible"));
        video3.AddComment(new Comment("John","I better go vegan"));
        video3.AddComment(new Comment("Eva","I should be doing homework"));
        video3.AddComment(new Comment("Jair","I'm ready for next camp"));

        video4.AddComment(new Comment("Dieter","I can relate on this!"));
        video4.AddComment(new Comment("Edian","Who is watching this in 2025?"));
        video4.AddComment(new Comment("Wendy","My family eats an M&M each time we hear Jesus Christ"));
        video4.AddComment(new Comment("Ivy","I'm done, whatever I do, I fall asleep."));

        List<Video> videos = new List<Video> {video1, video2, video3, video4};

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetDisplayText());
            Console.WriteLine();
        }

    }
}