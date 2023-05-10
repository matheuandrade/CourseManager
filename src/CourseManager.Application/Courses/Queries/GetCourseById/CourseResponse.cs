namespace CourseManager.Application.Courses.Queries.GetCourseById;

public sealed record CourseResponse(string Description,
            string LongDescription,
            string IconUrl,
            string CourseListIcon,
            string Category,
            int LessonsCounter,
            int SequenceNumber,
            string Url,
            decimal Price);

