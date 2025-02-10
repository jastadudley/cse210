namespace Homework;

public class WrightigAssignment : Assignment
{
    private string _title;
    
    public WritingAssignment(string student name, string topic, string title)
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