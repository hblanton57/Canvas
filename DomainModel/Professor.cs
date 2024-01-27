namespace DomainModel;

public class Professor : User
{
    public void CreateAnnouncement()
    {
        Console.WriteLine("Enter announcement title:");
        string announcementTitle = Console.ReadLine();

        Console.WriteLine("Enter announcement details:");
        string announcementDetails = Console.ReadLine();      
    }

    public void CreateModule()
    {
        Console.WriteLine("Enter module title:");
        string moduleTitle = Console.ReadLine();

        Console.WriteLine("Enter module details:");
        string moduleDetails = Console.ReadLine();
    }

    public void CreateAssignment()
    {
        Console.WriteLine("Enter assignment title:");
        string assignmentTitle = Console.ReadLine();

        Console.WriteLine("Enter points available:");
        int pointsAvailable = Console.ReadLine();

        Console.WriteLine("Enter assignment details:");
        string assignmentDetails = Console.ReadLine();

        Console.WriteLine("Enter assignment rubric:");
        string assignmentRubric = Console.ReadLine();

        Assignment newAssignment = new Assignment(assignmentTitle, pointsAvailable, assignmentDetails, assignmentRubric);
    }

    public void GradeAssignment()
    {
        Console.WriteLine("Enter assignment title to grade:");
        string assignmentTitle = Console.ReadLine();

        Console.WriteLine("Enter assignment grade:");
        string assignmentGrade = Console.ReadLine();
    }

}
