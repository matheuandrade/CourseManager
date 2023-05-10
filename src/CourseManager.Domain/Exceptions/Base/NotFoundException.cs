namespace CourseManager.Domain.Exceptions.Base;

public class NotFoundException : Exception
{
    public NotFoundException(string message)
    {
        throw new NotFoundException(message);
    }
}

