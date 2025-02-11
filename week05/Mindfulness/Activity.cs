

using System.Runtime.CompilerServices;

public class Activity
{
    private string _name;
    private string _description;
    private string _duration;

    public Activity(string name, string description, string duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"You have chosen {_name}.");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"Please prepare to focus and relax as we load your activity...");
    }

    public vaoid DisplayEndingMessage()
    {
        Console.WriteLine("Congradulations, you have compleated your session.");
        Console.WriteLine($"");
    }
    
    public void PauseAnnimation()
    {
        return ;
    }


}
