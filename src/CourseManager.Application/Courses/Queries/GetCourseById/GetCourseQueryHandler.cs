using CourseManager.Application.Abstractions.Messaging;
using CourseManager.Application.Courses.Queries.GetCourseById;
using CourseManager.Domain.Abstractions;
using CourseManager.Domain.Exceptions;
using CourseManager.Domain.Shared;

namespace CourseManager.Application.Courses.Queries;

public class GetCourseQueryHandler : IQueryHandler<GetCourseByIdQuery, CourseResponse>
{
    private readonly ICourseRepository _courseRepository;

    public GetCourseQueryHandler(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository; 
    }

    public async Task<Result<CourseResponse>> Handle(
        GetCourseByIdQuery request, CancellationToken cancellationToken)
    {
        var course = await _courseRepository.GetCourse(request.courseId)
                     ?? throw new CourseNotFoundException(request.courseId);

        return new CourseResponse(course.Category,
                                   course.LongDescription,
                                   course.IconUrl,
                                   course.CourseListIcon,
                                   course.Category,
                                   course.LessonsCounter,
                                   course.SequenceNumber,
                                   course.Url,
                                   course.Price); 
    }
}

