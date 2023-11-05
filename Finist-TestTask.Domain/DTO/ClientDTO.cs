namespace Finist_TestTask.Domain.DTO;

public record ClientDTO(string Name, string SecondName, string Patronymic, string PhoneNumber,
    string? CardAccount, string? DemandAccount, string? ExpressAccount);