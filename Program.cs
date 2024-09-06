
public class Students
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }

    public int ClassId { get; set; }
}
public class Classes
{
    public int ClassId { get; set; }
    public string ClassName { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Students> students = new List<Students>
        {
            new Students {StudentId = 1, StudentName = "Burak Kırıcı", ClassId = 1 },
            new Students {StudentId = 2, StudentName = "Emre Can Terkan", ClassId = 2},
            new Students {StudentId = 3, StudentName = "Ahmet", ClassId = 1},
            new Students {StudentId = 4, StudentName = "Mehmet", ClassId = 3},
            new Students {StudentId = 2, StudentName = "Ferit", ClassId = 1}


         };

        List<Classes> classes = new List<Classes>
        {
            new Classes { ClassId = 1, ClassName = "Türkçe" },
            new Classes { ClassId = 2, ClassName = "matematik" },
            new Classes { ClassId = 3, ClassName = "Kimya" }
        };

        var groupedClasses = from c in classes
                           join s in students on c.ClassId equals s.ClassId into studentGroup
                           select new
                           {
                               Class = c.ClassName,
                               Students = studentGroup
                           };

        foreach (var studentGroup in groupedClasses)
        {
            Console.WriteLine($"Class : {studentGroup.Class}");
            foreach (var student in studentGroup.Students)
            {
                Console.WriteLine($"Student Name - {student.StudentName}");
            }
        }
    }
}
