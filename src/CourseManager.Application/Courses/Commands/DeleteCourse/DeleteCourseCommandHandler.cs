using CourseManager.Application.Abstractions.Messaging;
using CourseManager.Domain.Abstractions;
using CourseManager.Domain.Shared;

namespace CourseManager.Application.Courses.Commands.DeleteCourse;

internal sealed class DeleteCourseCommandHanlder : ICommandHandler<DeleteCourseCommand>
{
    private readonly ICourseRepository _courseRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteCourseCommandHanlder(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
    {
        _courseRepository = courseRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result> Handle(DeleteCourseCommand request, CancellationToken cancellationToken)
    {
        var course = await _courseRepository.GetCourse(request.CourseId);

        if(course is null)
        {
             return Result.Failure(
                    new Error(
                        "Course.NotFound",
                        $"The Course with the identifier {request.CourseId} was not found."));
        }

        _courseRepository.Delete(course);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
}

