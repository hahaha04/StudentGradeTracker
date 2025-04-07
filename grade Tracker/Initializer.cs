using GradeTracker;

public class Initializer
{
   public static void Main()
   {
      UGStudent student1=new UGStudent();
      student1.Name="Harshitha Nunna";

      PGStudent student2=new PGStudent();
      student2.Name="Yaswini";

      DiplomaStudent student3=new DiplomaStudent();
      student3.Name="Asritha";

      Subject subject1=new Subject();
      subject1.GetGradePoints("A");
      subject1.GetGradePoints("B");
      subject1.GetGradePoints("C");
      

      Subject subject2=new Subject();
      subject2.GetGradePoints("B");
      subject2.GetGradePoints("C");

      Subject subject3=new Subject();
      subject1.GetCredits("Maths");
      subject1.GetGradePoints("B");
      subject3.GetCredits("Physics");
      subject3.GetGradePoints("B");
      subject3.GetCredits("Chemistry");
      subject3.GetGradePoints("C");

      

      student1.CalculateGPA(subject1.Points,subject1.Credits);
      student2.CalculateGPA(subject2.Points,subject2.Credits);
      student3.CalculateGPA(subject3.Points,subject3.Credits);


   }
}

