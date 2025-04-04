using GradeTracker;

public class Initializer
{
   public static void Main()
   {
      UGStudent student1=new UGStudent();
      student1.Name="Harshitha Nunna";

      PGStudent student2=new PGStudent();
      student2.Name="Yaswini";

     /* DiplomaStudent student3=new DiplomaStudent();
      student3.name="Asritha";*/

      Subject subject1=new Subject();
      subject1.GetGradePoints("A");
      subject1.GetGradePoints("B");
      subject1.GetGradePoints("C");
      

      Subject subject2=new Subject();
      subject2.GetGradePoints("B");
      subject2.GetGradePoints("C");

     /* Subject subject3=new Subject();
      subject1.getCredits("Maths");
      subject1.getGradePoints("B");
      subject3.getCredits("Physics");
      subject3.getGradePoints("B");
      subject3.getCredits("Chemistry");
      subject3.getGradePoints("C");*/

      

      student1.CalculateGPA(subject1.Points);
      student2.CalculateGPA(subject2.Points);
      //student3.CalculateGPA(subject3.points,subject3.credits);


   }
}

