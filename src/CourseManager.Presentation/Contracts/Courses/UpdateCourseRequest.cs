using CourseManager.Application.Abstractions.Messaging;

namespace CourseManager.Presentation.Contracts.Courses;

public record UpdateCourseRequest(
            Guid CourseId,
            string Description, 
            string LongDescription, 
            string IconUrl,
            string CourseListIcon,
            string Category,
            int LessonsCounter,
            int SequenceNumber,
            string Url,
            decimal Price) : ICommand;