namespace ContactList;

public class Contact : BaseClass
{
    public string Name { get; set; } = default!;
    public string MobileNumber { get; set; } = default!;
    public string? AlternateMobileNumber { get; set; }
    public string? WorkNumber { get; set; }
    public string? Email { get; set; }
    public ContactType? ContactType { get; set; }
}
