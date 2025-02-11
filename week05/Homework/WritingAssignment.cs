namespace Homework;

public class WritingAssignment : Assignment
{
    private string _title;
    
    public WritingAssignment(string studentName, string topic, string title)
        :base (studentName, topic)
    {
        _title = title;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName}";
    }

}