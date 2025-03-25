using System;
using System.Security.Cryptography.X509Certificates;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public String Username;

    public SayaTubeUser(String username)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.uploadedVideos = new List<SayaTubeVideo>();
        this.Username = username;
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            total += uploadedVideos[i].GetPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine("User: " + Username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}\n");
        }
    }
    
}

class SayaTubeVideo
{
    private int id;
    private String title;
    private int playCount;

    public SayaTubeVideo(String title)
    {
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID: " + id);
        Console.WriteLine("Judul Film: " + title);
        Console.WriteLine("Play Count: " + playCount);
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}  

class Program
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Agung");

        SayaTubeVideo video1 = new SayaTubeVideo("Ready Player One");
        video1.IncreasePlayCount(100);
        user.AddVideo(video1);

        SayaTubeVideo video2 = new SayaTubeVideo("Jurassic Park");
        video2.IncreasePlayCount(100);
        user.AddVideo(video2);

        SayaTubeVideo video3 = new SayaTubeVideo("Star Wars");
        video3.IncreasePlayCount(100);
        user.AddVideo(video3);

        SayaTubeVideo video4 = new SayaTubeVideo("Psycho");
        video4.IncreasePlayCount(100);
        user.AddVideo(video4);

        SayaTubeVideo video5 = new SayaTubeVideo("Scream");
        video5.IncreasePlayCount(100);
        user.AddVideo(video5);

        SayaTubeVideo video6 = new SayaTubeVideo("Joker");
        video6.IncreasePlayCount(100);
        user.AddVideo(video6);

        SayaTubeVideo video7 = new SayaTubeVideo("Spiderman");
        video7.IncreasePlayCount(100);
        user.AddVideo(video7);

        SayaTubeVideo video8 = new SayaTubeVideo("Aladdin");
        video8.IncreasePlayCount(100);
        user.AddVideo(video8);

        SayaTubeVideo video9 = new SayaTubeVideo("Avengers");
        video1.IncreasePlayCount(100);
        user.AddVideo(video1);

        SayaTubeVideo video10 = new SayaTubeVideo("Iron Man");
        video10.IncreasePlayCount(100);
        user.AddVideo(video10);

        user.PrintAllVideoPlaycount();
    }
}