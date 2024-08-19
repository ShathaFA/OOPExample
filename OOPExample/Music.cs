public interface IPlayable
{
    void Play();
    void Stop();
}
public class MusicPlayer : IPlayable
{
    public void Play()
    {
        Console.WriteLine("Music is playing.");
    }

    public void Stop()
    {
        Console.WriteLine("Music is stopped.");
    }
}
