namespace Trabajo_S6.DTo;

public class RegisterDto
{
    public string Nombre { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string DisplayName { get; set; } = string.Empty;
    public string Username { get; set; } = string.Empty;
    public string PhoneNumber  { get; set; } = string.Empty;
    public DateTime BithDay { get; set; } = DateTime.MaxValue;
    public string Country { get; set; } = string.Empty;
    public string Bio { get; set; } = string.Empty;
}