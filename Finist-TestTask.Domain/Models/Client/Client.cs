using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Finist_TestTask.Domain.Models.Client;

public class Client
{
    [Key]
    [Column(nameof(Id))]
    public Guid Id { get; set; }
    
    [Column(nameof(Name))]
    public string Name { get; set; }
    [Column(nameof(SecondName))]
    public string SecondName { get; set; }
    
    [Column(nameof(Patronymic))]
    public string Patronymic { get; set; }
    
    [Column(nameof(PhoneNumber))]
    public string PhoneNumber { get; set; }
    
    [Column(nameof(CardAccountId))]
    public Guid CardAccountId { get; set; }
    
    [Column(nameof(DemandAccountId))]
    public Guid DemandAccountId { get; set; }
    
    [Column(nameof(ExpressAccountId))]
    public Guid ExpressAccountId { get; set; }
}