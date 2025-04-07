using GradeTracker;
public class Subject
{
     public string SubjectName{ get; set; } = string.Empty;

     public string Grade{ get; set; } = string.Empty;

     public List<double> Points = new List<double>(); 
     public List<double> Credits = new List<double>(); 


     public void GetGradePoints(string Grade)
     {
          switch(Grade)
          {
            case "A":
               Points.Add(4.0);
               break;

            case "B":
               Points.Add(3.0);
               break;

            case "C":
               Points.Add(2.0);
               break;

            case "D":
               Points.Add(1.0);
               break;

             case "F":
               Points.Add(0.0);
               break;

             default:
                Points.Add(0.0);
                break;
          }
     }

    public void GetCredits(string SubjectName){
          switch(SubjectName)
          {
            case "Maths":
               Credits.Add(5.0);
               break;

            case "Physics":
               Credits.Add(4.0);
               break;

            case "Chemistry":
               Credits.Add(3.0);
               break;

             default:
                Credits.Add(0.0);
                break;
          }
     }
}