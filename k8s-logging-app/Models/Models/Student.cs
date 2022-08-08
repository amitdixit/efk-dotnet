using System.ComponentModel.DataAnnotations.Schema;

namespace Models.Models;

public class Student
{
    public int StudentId { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }
    public DateTime EnrollmentDate { get; set; }

    public string FullName => $"{LastName}, {FirstMidName}";

    public ICollection<Enrollment> Enrollments { get; set; }
}


public enum Grade
{
    A, B, C, D, F
}

public class Enrollment
{
    public int EnrollmentId { get; set; }
    public int CourseId { get; set; }
    public int StudentId { get; set; }
    public Grade? Grade { get; set; }

    public Course Course { get; set; }
    public Student Student { get; set; }
}
public class Course
{
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int CourseId { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }

    public ICollection<Enrollment> Enrollments { get; set; }
}