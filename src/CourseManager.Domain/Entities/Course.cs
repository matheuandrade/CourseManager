using CourseManager.Domain.Primitives;

namespace CourseManager.Domain.Entities;

public sealed class Course : Entity
{
    public Course(string description, 
                string longDescription, 
                string iconUrl,
                string courseListIcon,
                string category,
                int lessonsCounter,
                int sequenceNumber,
                string url,
                decimal price)
                {
                    Description = description;
                    LongDescription = longDescription;
                    IconUrl = iconUrl;
                    CourseListIcon = courseListIcon;
                    Category = category;
                    LessonsCounter = lessonsCounter;
                    SequenceNumber = sequenceNumber;
                    Url = url;
                    Price = price;
                }

    public void UpdateCourse(string description,
                                string longDescription,
                                string iconUrl,
                                string courseListIcon,
                                string category,
                                int lessonsCounter,
                                int sequenceNumber,
                                string url,
                                decimal price)
                {
                    Description = description;
                    LongDescription = longDescription;
                    IconUrl = iconUrl;
                    CourseListIcon = courseListIcon;
                    Category = category;
                    LessonsCounter = lessonsCounter;
                    SequenceNumber = sequenceNumber;
                    Url = url;
                    Price = price;
                }

    public string Description { get; private set; } = string.Empty;

    public string LongDescription { get; private set; } = string.Empty;

    public string IconUrl { get; private set; } = string.Empty;

    public string CourseListIcon { get; private set; } = string.Empty;

    public string Category { get; private set; } = string.Empty;

    public int LessonsCounter { get; private set; }
    
    public int SequenceNumber { get; private set; }

    public string Url { get; private set; } = string.Empty;

    public decimal Price { get; private set; }
}