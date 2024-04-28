using Adeverinte_Backend.Entities.Enums;

namespace Adeverinte_Backend.Controllers.Students;

public class StudentRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Faculty { get; set; }
    public string Speciality { get; set; }
    public string Email { get; set; }
    public int Year { get; set; }
    public string Marca { get; set; }
    public RoleEnum Role { get; set; }
}