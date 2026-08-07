
using Microsoft.Extensions.Logging;

namespace NuGet.SampleSharedModels.Interfaces
{
    public interface ISharedServicesClient
    {
        Task LogAsync(string category, string message, LogLevel level);
    }
}
