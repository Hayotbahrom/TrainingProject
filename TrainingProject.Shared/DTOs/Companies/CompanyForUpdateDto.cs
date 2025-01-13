namespace TrainingProject.Shared.DTOs;

public class CompanyForUpdateDto
{
    public string Name { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public bool IsActive { get; set; }
}
