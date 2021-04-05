using System.Linq;

namespace Queries
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            var course = new Course
            {
                Name = "New Course",
                Description = "New Description",
                FullPrice = 19.95f,
                Level = 1,
                Author = new Author { Id = 1, Name = "Mosh" }
            };

            context.Courses.Add(course);

            context.SaveChanges();








            System.Console.ReadLine();

        }
    }
}
