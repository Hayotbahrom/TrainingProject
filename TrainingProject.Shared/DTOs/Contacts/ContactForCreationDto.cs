namespace TrainingProject.Shared.DTOs.Contacts;

public class ContactForCreationDto
{
    public Guid CompanyId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Notes { get; set; }
}
