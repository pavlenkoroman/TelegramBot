namespace Bot.Domain.ValueObjects;

public class FullName(string firstName, string lastName, string middleName) : BaseValueObject
{
    public string FirstName { get; } = firstName;
    public string LastName { get; } = lastName;
    public string MiddleName { get; } = middleName;

    //TODO: FluentValidation

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return FirstName;
        yield return LastName;
        yield return MiddleName;
    }
}