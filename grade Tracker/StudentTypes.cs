using GradeTracker;

public class UGStudent:Student
{
      public override void CalculateGPA(List<double> points,List<double> credits){
         double sum=0;
         int count=points.Count;
         foreach(double grade in points)
         {
            sum+=grade;
         }
         double avg=sum/count;
         Console.WriteLine(Name+" (Undergraduate) - GPA: "+Math.Round(avg,2));
      }

}
public class PGStudent:Student
{
      public override void CalculateGPA(List<double> points,List<double> credits){
         double sum=0;
         int count=points.Count;
         foreach(double grade in points)
         {
            sum+=grade;
         }
         double avg=sum/count;
         double result=avg+(0.1*avg);
         Console.WriteLine(Name+" (Postgraduate) - GPA: "+Math.Round(result,2));
      }

}
public class DiplomaStudent:Student
{
      public override void CalculateGPA(List<double> points,List<double> credits){
         double sum=0;
         int count=points.Count;
         double totalcredit=0;
         for(int i=0;i<points.Count;i++){
            sum+=points[i]*credits[i];
            totalcredit +=credits[i];
         }

         double avg=sum/totalcredit;
         Console.WriteLine(Name+" (Diploma) - GPA: "+Math.Round(avg,2));
      }

}