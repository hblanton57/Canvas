namespace DomainModel;

public class Assignment
{
    private string title;
    private int pointsAvailable;
    private string details;
    private string rubric;

    public Assignment(string assignmentTitle, int assignmentTotalPoints, string assignmentDetails, string assignmentRubric){
        title = assignmentTitle;
        pointsAvailable = assignmentTotalPoints;
        dueDate = assignmentDueDate;
        details = assignmentDetails;
        rubric = assignmentRubric;
    }

}


