using Fama_Segura.Core.Application.DTOs.Email;
using Fama_Segura.Core.Domain.Settings;

namespace Fama_Segura.Core.Application.Interfaces.Services
{
    public interface IEmailService
    {
        public MailSettings MailSettings { get; }
        Task SendAsync(EmailRequest request);
    }
}
