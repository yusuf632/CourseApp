
namespace Basics.Models
{
    public class repository
    {
        private static readonly List<Course> _courses = new();

        static repository()
        {
            _courses = new List<Course>
            {
                new Course { Id = 1, Title = "Aspnet kursu", Description = "güzel bir kurs", Image="1.jpg", Tags = new string[] { "aspnet", "web" }, isActive = true, isHome = true },
                new Course { Id = 2, Title = "php kursu", Description = "güzel bir kurs", Image="2.jpg", Tags = new string[] { "php", "web" }, isActive = true, isHome = true },
                new Course { Id = 3, Title = "django kursu", Description = "güzel bir kurs", Image="3.jpg", isActive = true, isHome = false },
                new Course { Id = 4, Title = "javascript kursu", Description = "güzel bir kurs", Image="1.jpg", isActive = true, isHome = true},
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }
    }
}