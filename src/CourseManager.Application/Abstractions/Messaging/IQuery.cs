using CourseManager.Domain.Shared;
using MediatR;

namespace CourseManager.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}

