using NBSoft.Application.DTOs.Email;

namespace NBSoft.Application.Interfaces.Email
{
    public interface IEmailService
    {
        Task SendAsync(EmailRequestDto request);
    }
}
