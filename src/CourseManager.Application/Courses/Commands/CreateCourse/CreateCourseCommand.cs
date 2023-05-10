using CourseManager.Application.Abstractions.Messaging;
using MediatR;

namespace CourseManager.Application.Courses.Commands.CreateCourse;

public sealed record CreateCourseCommand(string Description, 
                                        string LongDescription, 
                                        string IconUrl,
                                        string CourseListIcon,
                                        string Category,
                                        int LessonsCounter,
                                        int SequenceNumber,
                                        string Url,
                                        decimal Price) : ICommand<Guid>;

