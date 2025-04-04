using GradeTracker;

public class UGStudent:Student
{
      public override void CalculateGPA(List<double> points/*,List<double> credits*/){
         double sum=0;
         int count=points.Count;
         foreach(double grade in points)
         {
            sum+=grade;
         }
         double avg=sum/count;
         Console.WriteLine(Name+" (Undergraduate) - GPA: "+avg);
      }

}
public class PGStudent:Student
{
      public override void CalculateGPA(List<double> points/*,List<double> credits*/){
         double sum=0;
         int count=points.Count;
         foreach(double grade in points)
         {
            sum+=grade;
         }
         double avg=sum/count;
         double result=avg+(0.1*avg);
         Console.WriteLine(Name+" (Postgraduate) - GPA: "+result);
      }

}
/*public class DiplomaStudent:Student{
      public override void CalculateGPA(List<double> points,List<double> credits){
         double sum=0;
         int count=points.Count;
         double totalcredit=0;
         foreach(double credit in credits){
         foreach(double grade in points){
            sum+=grade*credit;
            totalcredit +=credit;
         }}

         double avg=sum/totalcredit;
         Console.WriteLine(name+" (Diploma) - GPA: "+avg);
      }

}*/