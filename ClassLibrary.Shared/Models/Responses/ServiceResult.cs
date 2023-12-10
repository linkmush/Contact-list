using ClassLibrary.Shared.Enums;
using ClassLibrary.Shared.Interfaces;

namespace ClassLibrary.Shared.Models.Responses;

public class ServiceResult : IServiceResult
{
    public ServiceStatus Status { get; set; }
    public object Result { get; set; } = null!;
}
