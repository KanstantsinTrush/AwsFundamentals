namespace Customers.Api.Domain;

public class Customer
{
    public Guid Id { get; init; } = Guid.NewGuid();

    public string GitHubUsername { get; init; }

    public string FullName { get; init; }

    public string Email { get; init; }

    public DateTime DateOfBirth { get; init; }
}
