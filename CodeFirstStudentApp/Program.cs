using System;


namespace CodeFirstStudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                var student = new Student
                {
                    StudentName = "Bill",
                    DateOfBirth = new DateTime(2000, 5, 12),
                    Height = 5.9m,
                    Weight = 160.5f,
                    Grade = new Grade
                    {
                        GradeName = "10th Grade",
                        Section = "A"
                    }
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added successfully.");
                Console.ReadLine();
            }
        }
    }
}
