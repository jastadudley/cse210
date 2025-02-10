namespace Homework;

public class Homework
{
    private string _studentName;
    private string _topic;

    public Homework(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}