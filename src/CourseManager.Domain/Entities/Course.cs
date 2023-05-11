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

    public string Description { get; set; } = string.Empty;

    public string LongDescription { get; set; } = string.Empty;

    public string IconUrl { get; set; } = string.Empty;

    public string CourseListIcon { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public int LessonsCounter { get; set; }
    
    public int SequenceNumber { get; set; }

    public string Url { get; set; } = string.Empty;

    public decimal Price { get; set; }
}