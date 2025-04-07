namespace GradeTracker;
public abstract class Student
{
     Guid Id { get; set; }
     public string Name { get; set; } = string.Empty;

     public  void AddSubject(string subjectName, string grade){
           string subjectName1=subjectName;
           string grade1=grade;
     }

     public abstract void CalculateGPA(List<double> points,List<double> credits );
}