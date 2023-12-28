namespace SqsPublisher;

public class CustomerCreated
{
    public Guid Id { get; init; }
    
    public string FullName { get; init; }
    
    public string Email { get; init; }
    
    public string GitHubUSername { get; init; }
    
    public DateTime DateOfBirth { get; init; }
}