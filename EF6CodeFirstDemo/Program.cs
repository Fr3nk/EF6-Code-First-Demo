using System;

namespace EF6CodeFirstDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var student = new Student() { StudentName = "John" };

                ctx.Students.Add(student);
                ctx.SaveChanges();
           
      

                var teacher = new Teacher()
                {

                    TeacherName = "Frau Rottweiler",
                    ModeOfTeaching = TeachingMode.Online

                };

                ctx.TeacherInfo.Add(teacher);
                ctx.SaveChanges();
            }
            Console.WriteLine("Demo completed.");
            Console.ReadLine();
        }
    }
}