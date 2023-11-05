namespace Finist_TestTask.Domain.Models.Account.Base;

public class Account
{
    public Guid Id { get; set; }
    public string AccountNumber { get; set; }
    public Guid UserId { get; set; }
}