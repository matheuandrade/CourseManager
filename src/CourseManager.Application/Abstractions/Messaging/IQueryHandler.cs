using CourseManager.Domain.Shared;
using MediatR;

namespace CourseManager.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse>
    : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}

