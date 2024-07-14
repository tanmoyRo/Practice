namespace AbstractMethodsandClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProgrammingCourse _programmingCourse = new ProgrammingCourse("CS101","C#","John Doe",40);
            MathCourse _mathCourse = new MathCourse("MTH101", "Probability", "John", 50);

            _programmingCourse.CalculateTotalHours();
            _programmingCourse.PrintCourseDetails();

            _mathCourse.CalculateTotalHours();
            _mathCourse.PrintCourseDetails();

            Console.ReadKey();
        }
    }

    public abstract class Course
    {
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public string? Instructor { get; set; }
        public int DurationHours { get; set; }

        public abstract void CalculateTotalHours();
        public abstract void PrintCourseDetails();
    }

    public class ProgrammingCourse : Course
    {
        public ProgrammingCourse(string _coursecode, string _courseName, string _instructor, int _durationHours)
        {
            base.CourseCode = _coursecode;
            base.CourseName= _courseName;
            base.Instructor = _instructor;
            base.DurationHours = _durationHours;
        }
        public override void  CalculateTotalHours()
        {
            Console.WriteLine($"Total Hours in Programming={DurationHours}");
        }

        public override void PrintCourseDetails()
        {
            Console.WriteLine($"Course Code: {CourseCode}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Instructor: {Instructor}");
            Console.WriteLine($"Duration Hours: {DurationHours}");
        }
    }

    // Define the derived class MathCourse
    public class MathCourse : Course
    {
        public MathCourse(string _coursecode, string _courseName, string _instructor, int _durationHours)
        {
            base.CourseCode = _coursecode;
            base.CourseName = _courseName;
            base.Instructor = _instructor;
            base.DurationHours = _durationHours;
        }
        public override void CalculateTotalHours()
        {
            Console.WriteLine( $"Total Hours in MathCourse={DurationHours}");
        }

        public override void PrintCourseDetails()
        {
            Console.WriteLine($"Course Code: {CourseCode}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Instructor: {Instructor}");
            Console.WriteLine($"Duration Hours: {DurationHours}");
            
        }
    }

}
