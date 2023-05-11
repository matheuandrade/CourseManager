namespace CourseManager.Presentation.Contracts.Courses;

public record CreateCourseRequest(string Description, 
            string LongDescription, 
            string IconUrl,
            string CourseListIcon,
            string Category,
            int LessonsCounter,
            int SequenceNumber,
            string Url,
            decimal Price);