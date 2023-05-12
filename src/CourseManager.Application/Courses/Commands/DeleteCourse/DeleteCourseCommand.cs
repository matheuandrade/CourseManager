using CourseManager.Application.Abstractions.Messaging;

namespace CourseManager.Application.Courses.Commands.DeleteCourse;

public sealed record DeleteCourseCommand(Guid CourseId) : ICommand;

