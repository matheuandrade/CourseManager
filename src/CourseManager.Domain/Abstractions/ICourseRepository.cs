using CourseManager.Domain.Entities;

namespace CourseManager.Domain.Abstractions;

public interface ICourseRepository 
{
    Task Insert(Course course);
    void Update(Course course);

    Task<Course?> GetCourse(Guid courseId);
}