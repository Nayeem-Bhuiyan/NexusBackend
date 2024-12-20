using NBSoft.Application.Interfaces.DateFunctions;

namespace NBSoft.Infrastructure.Services
{
    public class DateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}