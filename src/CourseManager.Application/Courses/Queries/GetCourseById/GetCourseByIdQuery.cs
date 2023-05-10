using CourseManager.Application.Abstractions.Messaging;
using CourseManager.Application.Courses.Queries.GetCourseById;

namespace CourseManager.Application.Courses.Queries;

public sealed record GetCourseByIdQuery(Guid courseId) : IQuery<CourseResponse>;

