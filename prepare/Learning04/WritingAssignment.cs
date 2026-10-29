public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
    : base(studentName, topic)
    {
        _title = title;
    }



    public string GetWritingInformation()
    {
        // _student name must be protected or public for this to work
        return $"{_title} by {_studentName}";
    }
}