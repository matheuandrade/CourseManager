using CourseManager.Domain.Exceptions.Base;

namespace CourseManager.Domain.Exceptions;

public sealed class CourseNotFoundException : NotFoundException
{
    public CourseNotFoundException(Guid courseId)
        : base($"The course with id {courseId} was not found.")
        {
            
        }
}

