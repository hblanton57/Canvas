namespace DomainModel;

public class Course
{
    private string courseName;
    private User professor;
    private List<Student> students;

    public Course(string courseName, User professor)
    {
        this.courseName = courseName;
        this.professor = professor;
        this.students = new List<Student>();
    }
   

}


