using CourseManager.Application.Abstractions.Messaging;

namespace CourseManager.Application.Courses.Commands.UpdateCourse;

public sealed record UpdateCourseCommand(Guid CourseId,
                                        string Description, 
                                        string LongDescription, 
                                        string IconUrl,
                                        string CourseListIcon,
                                        string Category,
                                        int LessonsCounter,
                                        int SequenceNumber,
                                        string Url,
                                        decimal Price) : ICommand;

