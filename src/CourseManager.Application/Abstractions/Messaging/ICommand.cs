using CourseManager.Domain.Shared;
using MediatR;

namespace CourseManager.Application.Abstractions.Messaging;

public interface ICommand : IRequest<Result>
{
}

public interface ICommand<TResponse> : IRequest<Result<TResponse>>
{

}

