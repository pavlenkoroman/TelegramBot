using Bot.Domain.Primitives;
using Bot.Domain.ValueObjects;

namespace Bot.Domain.Entities;

public class User : BaseEntity
{
    public int Age => DateTime.UtcNow.Year - BirthDate.Year;
    public FullName FullName { get; private set; }
    public DateTime BirthDate { get; private set; }
    public Gender Gender { get; private set; }
    public string Phone { get; private set; }
    public string TelegramId { get; private init; }

    public User(FullName fullName, DateTime birthDate, Gender gender, string phone, string telegramId)
    {
        Id = Guid.NewGuid();
        FullName = fullName;
        BirthDate = birthDate;
        Gender = gender;
        Phone = phone;
        TelegramId = telegramId;
    }
}