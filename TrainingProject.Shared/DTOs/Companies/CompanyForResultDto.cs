namespace TrainingProject.Shared.DTOs.Companies;

public class CompanyForResultDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }
    public string Website { get; set; }
    public bool IsActive { get; set; }
    public DateTime ChangedAt { get; set; }
    public string ChangedBy { get; set; }
    public DateTime InsertedAt { get; set; }
    public string InsertedBy { get; set; }
}
