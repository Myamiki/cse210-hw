//This is the base Assigment class 
public class Assignment
{
    //member variables
    private string _studentName;
    private string _topic;

    //This is a constructor that receives a student name, topic and
    //sets the member variable.
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
   //when this method is called it gives a value stored in the variable
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetTopic()
    {
        return _topic;
    }
    //This method returns a summary that combines both the student's name and the topic
    //it takes the student's name adds a dash and then adds the topic
    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }
}