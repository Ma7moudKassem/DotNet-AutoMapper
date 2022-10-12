namespace DotNet_AutoMapper;

public class Employee : BaseEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int? Age { get; set; }
    public string? Address { get; set; }
    public double? Salary { get; set; }
}
