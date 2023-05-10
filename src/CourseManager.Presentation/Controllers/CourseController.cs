using CourseManager.Application.Courses.Commands.CreateCourse;
using CourseManager.Application.Courses.Queries;
using CourseManager.Application.Courses.Queries.GetCourseById;
using CourseManager.Domain.Shared;
using CourseManager.Presentation.Abstractions;
using CourseManager.Presentation.Contracts.Courses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CourseManager.Presentation.Controllers;

[Route("api/courses")]
    public sealed class CourseController : ApiController
    {
        public CourseController(ISender sender)
            : base(sender)
        {
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCourseById(
            Guid id,
            CancellationToken cancellationToken)
        {
            var query = new GetCourseByIdQuery(id);

            Result<CourseResponse> response = await Sender.Send(
                query,
                cancellationToken);

            return response.IsSuccess
                ? Ok(response.Value)
                : NotFound(response.Error);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(
            [FromBody] CreateCourseRequest request, 
            CancellationToken cancellationToken)
        {
            var command = new CreateCourseCommand(
                request.Description,
                request.LongDescription,
                request.IconUrl,
                request.CourseListIcon,
                request.Category,
                request.LessonsCounter,
                request.SequenceNumber,
                request.Url,
                request.Price);

            Result<Guid> result = await Sender.Send(command, cancellationToken);

            if(result.IsFailure)
            {
                return HandleFailure(result);
            }

            return CreatedAtAction(
               nameof(GetCourseById),
               new { id = result.Value },
               result.Value);
        }

        // [HttpPut("{id:guid}")]
        // public async Task<IActionResult> UpdateCourse(
        //     Guid id,
        //     [FromBody] UpdateMemberRequest request,
        //     CancellationToken cancellationToken)
        // {
        //     var command = new UpdateMemberCommand(
        //         id,
        //         request.FirstName,
        //         request.LastName);

        //     Result result = await Sender.Send(
        //         command,
        //         cancellationToken);

        //     if (result.IsFailure)
        //     {
        //         return HandleFailure(result);
        //     }

        //     return NoContent();
        // }
    }

