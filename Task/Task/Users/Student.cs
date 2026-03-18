namespace Task.Models;

public class Student : User
{
    public int studendNumber{set;get;}
    public int academicYear{set;get;}

    public Student(String firstName, String lastName, int studendNumber, int academicYear) : base(firstName, lastName)
    {
        this.studendNumber = studendNumber;
        this.academicYear = academicYear;
        
        userType = "Student";
    }
}