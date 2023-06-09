using CourseManager.Application.Abstractions.Messaging;
using CourseManager.Application.Courses.Commands.UpdateCourse;
using CourseManager.Domain.Abstractions;
using CourseManager.Domain.Shared;

namespace CourseManager.Application.Courses.Commands.CreateCourse;

internal sealed class UpdateCourseCommandHanlder : ICommandHandler<UpdateCourseCommand>
{
    private readonly ICourseRepository _courseRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateCourseCommandHanlder(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
    {
        _courseRepository = courseRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(UpdateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = await _courseRepository.GetCourse(request.CourseId);

        if(course is null)
        {
             return Result.Failure(
                    new Error(
                        "Course.NotFound",
                        $"The Course with the identifier {request.CourseId} was not found."));
        }

        course.UpdateCourse(request.Description,
                            request.LongDescription,
                            request.IconUrl,
                            request.CourseListIcon,
                            request.Category,
                            request.LessonsCounter,
                            request.SequenceNumber,
                            request.Url,
                            request.Price);

        _courseRepository.Update(course);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}

