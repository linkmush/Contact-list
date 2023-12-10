using ClassLibrary.Shared.Enums;

namespace ClassLibrary.Shared.Interfaces;

public interface IServiceResult
{
    object Result { get; set; }
    ServiceStatus Status { get; set; }
}