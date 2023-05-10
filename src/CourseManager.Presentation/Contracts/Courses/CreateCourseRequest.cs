namespace CourseManager.Presentation.Contracts.Courses;

public class CreateCourseRequest 
{
    public string Description { get; set; } = string.Empty;

    public string LongDescription { get; set; } = string.Empty;

    public string IconUrl { get; set; } = string.Empty;

    public string CourseListIcon { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public int LessonsCounter { get; set; }
    
    public int SequenceNumber { get; set; }

    public string Url { get; set; } = string.Empty;

    public decimal Price { get; set; }
}