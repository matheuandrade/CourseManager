using CourseManager.Domain.Abstractions;
using CourseManager.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CourseManager.Persistence.Repositories;

public sealed class CourseRepository : ICourseRepository
{
    private readonly ApplicationDbContext _context;

    public CourseRepository(ApplicationDbContext context) => _context = context;

    public async Task Insert(Course course) => await _context.Set<Course>().AddAsync(course);

    public void Update(Course course) => _context.Set<Course>().Update(course);

    public async Task<Course?> GetCourse(Guid courseId) => await _context.Set<Course>().FirstOrDefaultAsync(x => x.Id == courseId);
}