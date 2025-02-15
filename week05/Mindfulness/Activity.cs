namespace Mindfulness;
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"You have chosen {_name}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Please prepare to focus and relax as we load your activity...");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations, you have compleated your session.");
        Console.WriteLine($"You have spent {_duration} seconds practicing mindfulness.");
        Console.WriteLine("Take a moment to ground yourself back into your body before continuing your day.");
    }
    
    public void PauseAnnimation()
    {
        for (int i = 4; i > 0; i --)
        {
            Console.Write("...Loading");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }


}
