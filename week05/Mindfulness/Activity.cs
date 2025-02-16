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

    private static List<string> quotes = new List<string>()//MY CREATIVE ADDITION
        {
            "Do not dwell in the past, do not dream of the future, concentrate the mind on the present moment.— Gautama Buddha",//MY CREATIVE ADDITION
            "When you realize nothing is lacking, the whole world belongs to you.- Laozi, from the Tao Te Ching",//MY CREATIVE ADDITION
            "Peace comes from within. Do not seek it without.- Gautama Buddha",//MY CREATIVE ADDITION
            "When there is no desire, all things are at peace.- Laozi, Tao Te Ching",//MY CREATIVE ADDITION
            "Flow with whatever may happen, and let your mind be free: Stay centered by accepting whatever you are doing. This is the ultimate.- Zhuangzi"//MY CREATIVE ADDITION
        };
        
    public static void DisplayMindfulQuote()//MY CREATIVE ADDITION
    {
        Random rand = new Random();//MY CREATIVE ADDITION
        string selectedQuote = quotes[rand.Next(quotes.Count)];//MY CREATIVE ADDITION
        Console.WriteLine(selectedQuote);//MY CREATIVE ADDITION
        Console.WriteLine();//MY CREATIVE ADDITION
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations, you have compleated your session.");
        Thread.Sleep(2000);
        Console.WriteLine($"You have spent {_duration} seconds practicing mindfulness.");
        Console.WriteLine("Take a moment to ground yourself back into your body before continuing your day.");
        Thread.Sleep(4000);
    }
    
    public void PauseAnnimation()
    {
        for (int i = 15; i > 0; i --)
        {
            Console.Write(".");
            Thread.Sleep(2000);
        }
        Console.WriteLine();
    }
}
