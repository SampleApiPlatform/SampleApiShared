using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SampleSharedModels.Interfaces
{
    public interface ISharedServicesClient
    {
        Task LogAsync(string category, string message, LogLevel level);
    }
}
