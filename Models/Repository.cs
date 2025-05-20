namespace Basic.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {Id = 1, Title = "AspNet Course", Description = "Quality course.", Image = "1.jpg", Tags = new string[] {"aspnet", "Web Development"}, IsActive = true, IsHome = true },
                new Course() {Id = 2, Title = "Php Course", Description = "Quality course.", Image = "2.jpg", Tags = new string[] {"Php", "Web Development"}, IsActive = false, IsHome = true },
                new Course() {Id = 3, Title = "Django Course", Description = "Quality course.", Image = "3.jpg", Tags = new string[] {"Django", "Web Development", "Course"}, IsActive = true, IsHome = false },
                new Course() {Id = 4, Title = "Javascript Course", Description = "Quality course.", Image = "4.jpg", Tags = new string[] {"Javascript", "Web Development", "Course", "Front-end"}, IsActive = true, IsHome = true },
                new Course() {Id = 5, Title = "Java Course", Description = "Quality course.", Image = "5.jpg",  Tags = new string[] {"Java", "Web Programming", "Course", "Back-end"}, IsActive = true, IsHome = true }
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