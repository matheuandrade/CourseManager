using CourseManager.Application.Abstractions.Messaging;
using CourseManager.Domain.Abstractions;
using CourseManager.Domain.Entities;
using CourseManager.Domain.Shared;

namespace CourseManager.Application.Courses.Commands.CreateCourse;

internal sealed class CreateCourseCommandHanlder : ICommandHandler<CreateCourseCommand, Guid>
{
    private readonly ICourseRepository _courseRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateCourseCommandHanlder(ICourseRepository courseRepository, IUnitOfWork unitOfWork)
    {
        _courseRepository = courseRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<Result<Guid>> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
    {
        var course = new Course(request.Description,
                                request.LongDescription,
                                request.IconUrl,
                                request.CourseListIcon,
                                request.Category,
                                request.LessonsCounter,
                                request.SequenceNumber,
                                request.Url,
                                request.Price);

        await _courseRepository.Insert(course);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        return course.Id;
    }
}

