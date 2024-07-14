namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course _course1 = new Course();
            Course _course2 = new Course("ABCD123", "Python", "John Doe");
            _course1.DisplayDetails();
            _course2.DisplayDetails();

            Console.ReadKey();
        }
    }

    class Course
    {
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public string? Instructor { get; set; }
        public Course()
        {
            CourseCode = "CourseCodeAB";
            CourseName = "C#";
            Instructor = "Anonyn";
        }

        public Course(string _courseCode, string _courseName, string _instructor)
        {
            CourseCode = _courseCode;
            CourseName = _courseName;
            Instructor = _instructor;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Course Code : {CourseCode}");
            Console.WriteLine($"Course Name : {CourseName}");
            Console.WriteLine($"Instructor : {Instructor}");
        }
    }

}
