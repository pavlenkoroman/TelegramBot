namespace Bot.Domain.Entities;

public abstract class BaseEntity
{
    /// <summary>
    /// Entity unique indentifier
    /// </summary>
    public Guid Id { get; protected init; }

    public override bool Equals(object? obj)
    {
        if (obj is not BaseEntity entity)
        {
            return false;
        }

        if (ReferenceEquals(this, entity))
        {
            return true;
        }

        if (Id.Equals(default) || entity.Id.Equals(default))
        {
            return false;
        }

        return Id.Equals(entity.Id);
    }

    public override int GetHashCode()
    {
        return (GetType().ToString() + Id).GetHashCode();
    }

    public static bool operator ==(BaseEntity? a, BaseEntity? b)
    {
        if (a is null && b is null)
            return true;

        if (a is null || b is null)
            return false;

        return a.Equals(b);
    }

    public static bool operator !=(BaseEntity? a, BaseEntity? b)
    {
        return !(a == b);
    }
}